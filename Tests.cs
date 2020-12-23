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

        [Test]
        public void ClickHideOptions_CheckThatPanelHided()
        {
            // Arrange
            var homePage = Pages.Home.Open();
            Assert.IsTrue(homePage.OptionsIsVisible(),
                "Options should be visible");

            // Act
            homePage.HideOptions();

            // Assert
            Assert.IsFalse(homePage.OptionsIsVisible(),
                           "The options should be hided");
        }
    }
}
