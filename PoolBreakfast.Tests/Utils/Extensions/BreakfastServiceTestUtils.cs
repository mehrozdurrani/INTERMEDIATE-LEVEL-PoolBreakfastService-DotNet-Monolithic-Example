using PoolBreakfast.Api.Models;
using testConstants = PoolBreakfast.Tests.Utils.Constants.Constants;

namespace PoolBreakfast.Tests.Utils.Extensions
{
    public static class BreakfastServiceTestUtils
    {
        public static Breakfast CreateBreakfast()
        {
            return Breakfast
                .Create(
                    testConstants.BreakfastConstants.Name,
                    testConstants.BreakfastConstants.Description,
                    testConstants.BreakfastConstants.StartDateTime,
                    testConstants.BreakfastConstants.EndDateTime,
                    testConstants.BreakfastConstants.Savory,
                    testConstants.BreakfastConstants.Sweet
                )
                .Value;
        }
    }
}
