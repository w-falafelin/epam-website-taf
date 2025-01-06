using EpamWebsiteTAF.Core.Logger;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebElement FindElement(By by) => Driver.FindElement(by);

        protected ReadOnlyCollection<IWebElement> FindElements(By by) => Driver.FindElements(by);

        protected void ScrollToElement(IWebElement element)
        {
            var actions = new OpenQA.Selenium.Interactions.Actions(Driver);
            actions.MoveToElement(element).Perform();
        }

        protected void MoveToElementAndClick(By locator)
        {
            var element = FindElement(locator);
            var actions = new OpenQA.Selenium.Interactions.Actions(Driver);
            actions.MoveToElement(element)
                   .Click()
                   .Perform();
        }

        protected void MoveToElement(By locator)
        {
            var element = FindElement(locator);
            var actions = new OpenQA.Selenium.Interactions.Actions(Driver);
            actions.MoveToElement(element)
                   .Perform();
        }

        public bool ValidatePageTitle(string expectedTitle)
        {
            var actualTitle = Driver.Title;
            return actualTitle.Contains(expectedTitle, StringComparison.OrdinalIgnoreCase);
        }

        public bool IsElementPresent(By locator)
        {
            try
            {
                return Driver.FindElements(locator).Count > 0;
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Error while checking element presence: {ex.Message}");
                return false;
            }
        }
    }
}
