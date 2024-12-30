using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class GlobalSearchResultsPageActions
    {
        private readonly GlobalSearchResultsPage globalSearchResultsPage;

        public GlobalSearchResultsPageActions(IWebDriver driver)
        {
            globalSearchResultsPage = new GlobalSearchResultsPage(driver);
        }

        public bool VerifyAllSearchResultsContainText(string expectedText)
        {
            var searchResults = globalSearchResultsPage.GetSearchResultContainers();

            foreach (var result in searchResults)
            {
                if (!result.Text.Contains(expectedText, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
