using ErrorOr;

namespace PoolBreakfast.Api.Services.ErrorsService
{
    public static class Errors
    {
        public static class BreakFast
        {
            public static Error NotFound() => Error.NotFound(code: "Breakfast.NotFound", description: "Breakfast not found.");
        }
    }
}