using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace EpamWebsiteTAF.Core.Utilities
{
    public static class WaitHelper
    {
        private const int DefaultTimeoutInSeconds = 10;

        public static IWebElement WaitForElementToBeVisible(IWebDriver driver, By locator, int timeoutInSeconds = DefaultTimeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, By locator, int timeoutInSeconds = DefaultTimeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
