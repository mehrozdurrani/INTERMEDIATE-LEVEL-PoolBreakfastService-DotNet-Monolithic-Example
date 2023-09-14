using PoolBreakfast.Api.Models;

namespace PoolBreakfast.Api.Services.Breakfasts
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        void GetBreakfast(Guid id);
        void UpdateBreakfast(Breakfast breakfast);
        void DeleteBreakfast(Guid id);
    }
}