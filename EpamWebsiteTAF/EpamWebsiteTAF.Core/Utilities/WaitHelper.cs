using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using EpamWebsiteTAF.Core.Logger;

namespace EpamWebsiteTAF.Core.Utilities
{
    public static class WaitHelper
    {
        private const int DefaultTimeoutInSeconds = 10;

        public static IWebElement WaitForElementToBeVisible(IWebDriver driver, By locator, int timeoutInSeconds = DefaultTimeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return element;
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Element not visible: {locator}. Error: {ex.Message}");
                throw;
            }
        }

        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, By locator, int timeoutInSeconds = DefaultTimeoutInSeconds)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
                return element;
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Element not clickable: {locator}. Error: {ex.Message}");
                throw;
            }
        }
    }
}
