using Xunit;
using SampleEbApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SampleEbApp.Tests
{
    public class HelloControllerTests
    {
        [Fact]
        public void Get_ReturnsOk()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            var result = controller.Get() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result!.StatusCode ?? 200);
        }
    }
}
