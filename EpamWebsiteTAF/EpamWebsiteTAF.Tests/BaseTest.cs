using EpamWebsiteTAF.Core;
using EpamWebsiteTAF.Core.Logger;
using EpamWebsiteTAF.Core.Utilities;
using NUnit.Framework.Interfaces;

namespace EpamWebsiteTAF.Tests
{
    public abstract class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            DriverManager.InitializeDriver(BrowserType.Chrome);
            LogManager.InitializeLogger();

            string baseUrl = "https://www.epam.com/";
            DriverManager.WebDriver.Manage().Window.Maximize();

            DriverManager.WebDriver.Navigate().GoToUrl(baseUrl);
            LogManager.LogInfo($"Navigated to URL: {baseUrl}");

            LogManager.LogInfo("Test setup complete.");
        }

        [TearDown]
        public void TearDown()
        {
            string testName = TestContext.CurrentContext.Test.Name;

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshotPath = ScreenshotHelper.TakeScreenshot(DriverManager.WebDriver, testName);
                LogManager.LogError($"Test '{testName}' failed. Screenshot saved at{screenshotPath}.");
            }

            DriverManager.QuitDriver();
            LogManager.LogInfo("Test teardown complete.");
        }
    }
}