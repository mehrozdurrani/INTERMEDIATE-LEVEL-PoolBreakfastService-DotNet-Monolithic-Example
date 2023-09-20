using ErrorOr;
using PoolBreakfast.Api.Services.Breakfasts;
using PoolBreakfast.Tests.Utils.Extensions;
using Shouldly;

namespace PoolBreakfast.Tests
{
    public class BreakfastServiceTest
    {
        private readonly IBreakfastService _breakfastService;
        public BreakfastServiceTest()
        {
            _breakfastService = new BreakfastService();
        }
        [Fact]
        public void CreateBreakfastRequest_WhenRequestIsValid_ShouldReturnMenuWithId()
        {
            // Arrange
            var breakfast = BreakfastServiceTestUtils.CreateBreakfast();

            // Act
            var testServiceResult = _breakfastService.CreateBreakfast(breakfast).Value;

            // Assert
            testServiceResult.ShouldNotBeOfType<Error>();
            testServiceResult.ShouldBe(Result.Created);

        }
    }
}