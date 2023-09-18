using ErrorOr;
using PoolBreakfast.Api.Models;

namespace PoolBreakfast.Api.Services.Breakfasts
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        ErrorOr<Breakfast> GetBreakfast(Guid id);
        void UpdateBreakfast(Guid id, Breakfast breakfast);
        void DeleteBreakfast(Guid id);
    }
}