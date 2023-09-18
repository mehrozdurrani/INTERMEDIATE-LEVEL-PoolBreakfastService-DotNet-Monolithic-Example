using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using PoolBreakfast.Api.Models;
using PoolBreakfast.Api.Services.Breakfasts;
using PoolBreakfast.Contracts.Breakfast;

namespace PoolBreakfast.Api.Controllers
{
    /// <summary>
    /// We have added the '[Route("breakfasts")] attribute to the class as all the methods
    /// in the class will be mapped to the same route for example '/breakfasts/{id}' for
    /// GetBreakfast method is mapped to '{id}' now because of the '[Route("breakfasts")].
    /// Also we can make Route[("controller")] attribute and this will take the name of the
    /// controller class that is 'BreakFast' from 'BreakfastController'. 
    /// </summary>
    ///
    [Route("[controller]")]
    public class BreakfastController : ApiController
    {
        private readonly IBreakfastService _breakfastService;

        public BreakfastController(IBreakfastService breakfastService)
        {
            _breakfastService = breakfastService;
        }

        [HttpPost]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            var breakfast = new Breakfast(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet
            );

            // TODO: Add Breakfast to database
            _breakfastService.CreateBreakfast(breakfast);

            var response = new CreateBreakfastResponse(
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.StartDateTime,
                breakfast.EndDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet
            );
            return CreatedAtAction(
                nameof(GetBreakfast),
                new { id = breakfast.Id },
                response);
        }

        [HttpGet("{id}")]
        public IActionResult GetBreakfast(Guid id)
        {
            ErrorOr<Breakfast> getBreakfastResult = _breakfastService.GetBreakfast(id);

            return getBreakfastResult.Match(
                   breakfast => Ok(MapBreakfastResponse(breakfast)),
                   CustomProblem
               );
        }

        private static GetBreakfastResponse MapBreakfastResponse(Breakfast breakfast)
        {
            return new(
                            breakfast.Id,
                            breakfast.Name,
                            breakfast.Description,
                            breakfast.StartDateTime,
                            breakfast.EndDateTime,
                            breakfast.LastModifiedDateTime,
                            breakfast.Savory,
                            breakfast.Sweet);
        }

        [HttpPut("{id}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            var breakfast = new Breakfast(
                id,
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet);
            _breakfastService.UpdateBreakfast(id, breakfast);

            // TODO: Create new breakfast if Id does not exist
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            _breakfastService.DeleteBreakfast(id);
            return NoContent();
        }
    }
}