using EpamWebsiteTAF.Core.Logger;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Core
{
    public static class DriverManager
    {
        private static IWebDriver? webDriver;
        public static IWebDriver WebDriver
        {
            get
            {
                if (webDriver == null)
                {
                    LogManager.LogError("WebDriver is not initialized. Call InitializeDriver() first.");
                    throw new InvalidOperationException("WebDriver is not initialized.");
                }
                return webDriver;
            }
        }

        public static void InitializeDriver(BrowserType browserType)
        {
            webDriver = BrowserFactory.GetWebDriver(browserType);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void QuitDriver()
        {
            webDriver?.Quit();
            webDriver = null;
        }
    }
}
