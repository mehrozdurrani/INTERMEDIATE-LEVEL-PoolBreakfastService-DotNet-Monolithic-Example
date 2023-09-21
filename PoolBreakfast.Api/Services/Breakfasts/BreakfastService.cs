using ErrorOr;
using PoolBreakfast.Api.Models;
using PoolBreakfast.Api.Services.ErrorsService;

namespace PoolBreakfast.Api.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();

        public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
        {
            _breakfasts.Add(breakfast.Id, breakfast);
            return Result.Created;
        }

        public ErrorOr<Deleted> DeleteBreakfast(Guid id)
        {
            var ifBreakfastExists = _breakfasts.ContainsKey(id);
            if (ifBreakfastExists is not false)
            {
                _breakfasts.Remove(id);
                return Result.Deleted;
            }
            return Errors.BreakFast.NotFound();
        }

        public ErrorOr<Breakfast> GetBreakfast(Guid id)
        {
            var ifBreakfastExists = _breakfasts.ContainsKey(id);
            if (ifBreakfastExists is not false)
                return _breakfasts[id];
            return Errors.BreakFast.NotFound();
        }

        public ErrorOr<UpsertBreakfast> UpdateBreakfast(Guid id, Breakfast breakfast)
        {
            var ifBreakfastExists = _breakfasts.ContainsKey(id);
            if (ifBreakfastExists is false)
            {
                _breakfasts.Add(id, breakfast);
                return new UpsertBreakfast(false);
            }
            _breakfasts[breakfast.Id] = breakfast;
            return new UpsertBreakfast(true);
        }
    }
}
