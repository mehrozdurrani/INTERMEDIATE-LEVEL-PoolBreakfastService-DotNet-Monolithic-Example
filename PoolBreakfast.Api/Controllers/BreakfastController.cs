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
    [Route("controller")]
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
            var result = _breakfastService.GetBreakfast(id);
            GetBreakfastResponse response = new(
                result.Id,
                result.Name,
                result.Description,
                result.StartDateTime,
                result.EndDateTime,
                result.LastModifiedDateTime,
                result.Savory,
                result.Sweet);
            return Ok(response);
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
            return CreatedAtAction(nameof(GetBreakfast), new { id = breakfast.Id }, Ok());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok();
        }
    }
}