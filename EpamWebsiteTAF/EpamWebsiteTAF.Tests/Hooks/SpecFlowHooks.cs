using EpamWebsiteTAF.Core.Logger;
using EpamWebsiteTAF.Core;
using TechTalk.SpecFlow;
using EpamWebsiteTAF.Core.Utilities;
using NUnit.Framework.Interfaces;

namespace EpamWebsiteTAF.Tests.Hooks;

[Binding]
public class SpecFlowHooks
{
    [BeforeScenario]
    public void BeforeScenario()
    {
        DriverManager.InitializeDriver(BrowserType.Chrome);
        LogManager.InitializeLogger();

        DriverManager.WebDriver.Manage().Window.Maximize();

        string baseUrl = "https://www.epam.com/";
        DriverManager.WebDriver.Navigate().GoToUrl(baseUrl);
        LogManager.LogInfo($"Navigated to URL: {baseUrl}");

        LogManager.LogInfo("Scenario setup complete.");
    }

    [AfterScenario]
    public void AfterScenario()
    {
        string testName = TestContext.CurrentContext.Test.Name;

        if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        {
            var screenshotPath = ScreenshotHelper.TakeScreenshot(DriverManager.WebDriver, testName);
            LogManager.LogError($"Test '{testName}' failed. Screenshot saved at{screenshotPath}.");
        }

        DriverManager.QuitDriver();
        LogManager.LogInfo("Scenario teardown complete.");
    }
}
