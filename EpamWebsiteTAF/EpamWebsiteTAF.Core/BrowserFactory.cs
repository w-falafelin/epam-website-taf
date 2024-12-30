using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace EpamWebsiteTAF.Core
{
    public static class BrowserFactory
    {
        public static IWebDriver GetWebDriver(BrowserType browserType) => browserType switch
        {
            BrowserType.Chrome => new ChromeDriver(),
            BrowserType.Firefox => new FirefoxDriver(),
            BrowserType.Edge => new EdgeDriver(),
            _ => throw new ArgumentException("Unsupported browser type."),
        };
    }
}
