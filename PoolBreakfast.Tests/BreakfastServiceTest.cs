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
        public void CreateBreakfastRequest_WhenRequestIsValid_ShouldReturnResultIsCreated()
        {
            // Arrange
            var breakfast = BreakfastServiceTestUtils.CreateBreakfast();

            // Act
            var testServiceResult = _breakfastService.CreateBreakfast(breakfast).Value;

            // Assert
            testServiceResult.ShouldNotBeOfType<Error>();
            testServiceResult.ShouldBe(Result.Created);
        }

        [Fact]
        public void GetBreakfastRequest_WhenRequestIsValid_ShouldReturnResultIsBreakfast()
        {
            // Arrange
            var breakfast = BreakfastServiceTestUtils.CreateBreakfast();
            _ = _breakfastService.CreateBreakfast(breakfast);

            // Act
            var testServiceResult = _breakfastService.GetBreakfast(breakfast.Id);

            // Assert
            testServiceResult.Value.ShouldNotBeOfType<Error>();
            testServiceResult.Value.ShouldBe(breakfast);
        }

        [Fact]
        public void UpsertBreakfastRequest_WhenRequestIsValid_ShouldReturnResultIsNewlyCreated()
        {
            // Arrange
            var breakfast = BreakfastServiceTestUtils.CreateBreakfast();
            _ = _breakfastService.CreateBreakfast(breakfast);

            // Act
            var testServiceResult = _breakfastService.UpdateBreakfast(breakfast.Id, breakfast);

            // Assert
            testServiceResult.Value.IsNewlyCreated.ShouldBeTrue();
        }

        [Fact]
        public void DeleteBreakfastRequest_WhenRequestIsValid_ShouldReturnResultIsDeleted()
        {
            // Arrange
            var breakfast = BreakfastServiceTestUtils.CreateBreakfast();
            _ = _breakfastService.CreateBreakfast(breakfast);

            // Act
            var testServiceResult = _breakfastService.DeleteBreakfast(breakfast.Id);

            // Assert
            testServiceResult.ShouldNotBeOfType<Error>();
            testServiceResult.ShouldBe(Result.Deleted);
        }
    }
}
