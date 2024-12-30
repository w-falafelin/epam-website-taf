using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new InvalidOperationException("WebDriver is not initialized. Call InitializeDriver() first.");
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
