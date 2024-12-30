using OpenQA.Selenium;
using EpamWebsiteTAF.Core.Utilities;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class HomePage : BasePage
    {
        private readonly By searchIcon = By.ClassName("header-search__button");
        private readonly By searchField = By.CssSelector("input[type='search']");
        private readonly By findButton = By.ClassName("custom-search-button");
        private readonly By acceptCookiesButton = By.Id("onetrust-accept-btn-handler");

        public static By LinkLocator(string linkText) => By.LinkText($"{linkText}");

        public HomePage(IWebDriver driver) : base(driver) { }

        public void ClickSearchIcon()
        {
            FindElement(searchIcon).Click();
        }

        public void EnterSearchQuery(string query)
        {
            var search = FindElement(searchField);
            search.SendKeys(query);
        }

        public void CLickFindButton()
        {
            FindElement(findButton).Click();
        }

        public void AcceptAllCookies()
        {
            var button = WaitHelper.WaitForElementToBeClickable(Driver, acceptCookiesButton);
            var jsExecutor = (IJavaScriptExecutor)Driver;
            jsExecutor.ExecuteScript("arguments[0].click();", button);
        }

        public void ClickLinkByItsText(string text)
        {
            var locator = LinkLocator(text);
            FindElement(locator).Click();
        }
    }
}
