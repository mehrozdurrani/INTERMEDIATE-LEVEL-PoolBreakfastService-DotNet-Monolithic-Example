using ErrorOr;

namespace PoolBreakfast.Api.Services.ErrorsService
{
    public static class Errors
    {
        public static class BreakFast
        {
            public static Error InvalidName() => Error.Validation(code: "Breakfast.InvalidName", description: "Name must be between 5 and 50 characters.");
            public static Error InvalidDescription() => Error.Validation(code: "Breakfast.InvalidDescription", description: "Description must be between 5 and 100 characters.");
            public static Error NotFound() => Error.NotFound(code: "Breakfast.NotFound", description: "Breakfast not found.");
        }
    }
}