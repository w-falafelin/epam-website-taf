using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class GlobalSearchResultsPage : BasePage
    {
        private readonly By searchResultContainer = By.TagName("article");

        public GlobalSearchResultsPage(IWebDriver driver) : base(driver) { }

        public IReadOnlyCollection<IWebElement> GetSearchResultContainers()
        {
            return FindElements(searchResultContainer);
        }
    }
}
