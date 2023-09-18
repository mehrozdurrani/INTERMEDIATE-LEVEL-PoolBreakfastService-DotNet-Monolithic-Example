using ErrorOr;
using PoolBreakfast.Api.Models;
using PoolBreakfast.Api.Services.ErrorsService;

namespace PoolBreakfast.Api.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
        public void CreateBreakfast(Breakfast breakfast)
        {
            _breakfasts.Add(breakfast.Id, breakfast);
        }

        public void DeleteBreakfast(Guid id)
        {
            _breakfasts.Remove(id);
        }

        public ErrorOr<Breakfast> GetBreakfast(Guid id)
        {
            var ifBreakfastExists = _breakfasts.TryGetValue(id, out Breakfast? breakfast);
            if (ifBreakfastExists is not false)
                return _breakfasts[id];
            return Errors.BreakFast.NotFound();
        }

        public void UpdateBreakfast(Guid id, Breakfast breakfast)
        {
            _breakfasts[breakfast.Id] = breakfast;
        }
    }
}