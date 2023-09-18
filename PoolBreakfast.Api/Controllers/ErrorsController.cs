using Microsoft.AspNetCore.Mvc;

namespace PoolBreakfast.Api.Controllers
{
    public class ErrorsController : ApiController
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}