using NUnit.Framework;

namespace Selenium
{
    public class Tests : TestBase
    {
        [Test]
        public void PressRunButton_CheckOutputValue()
        {
            var expectedOutput = "Hello World";

            // Arrange
            var homePage = Pages.Home.Open();

            // Act
            homePage.PressRunButton();

            // Assert            
            Assert.AreEqual(expectedOutput,
                            homePage.GetOutputValue(),
                            $"Output should contains value {expectedOutput}");
        }
    }
}
