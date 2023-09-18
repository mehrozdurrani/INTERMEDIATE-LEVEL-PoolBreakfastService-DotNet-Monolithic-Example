using ErrorOr;
using PoolBreakfast.Api.Models;

namespace PoolBreakfast.Api.Services.Breakfasts
{
    public interface IBreakfastService
    {
        ErrorOr<Created> CreateBreakfast(Breakfast breakfast);
        ErrorOr<Breakfast> GetBreakfast(Guid id);
        ErrorOr<UpsertBreakfast> UpdateBreakfast(Guid id, Breakfast breakfast);
        ErrorOr<Deleted> DeleteBreakfast(Guid id);
    }
}