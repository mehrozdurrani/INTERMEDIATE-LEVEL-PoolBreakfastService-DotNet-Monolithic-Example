using PoolBreakfast.Api.Models;

namespace PoolBreakfast.Api.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private readonly Dictionary<Guid, Breakfast> _breakfasts = new();
        public void CreateBreakfast(Breakfast breakfast)
        {
            _breakfasts.Add(breakfast.Id, breakfast);
        }

        public void DeleteBreakfast(Guid id)
        {
            _breakfasts.Remove(id);
        }

        public Breakfast GetBreakfast(Guid id)
        {
            return _breakfasts[id];
        }

        public void UpdateBreakfast(Guid id, Breakfast breakfast)
        {
            _breakfasts[breakfast.Id] = breakfast;
        }
    }
}