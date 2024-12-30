using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class CareersSearchResultsPageActions
    {
        private readonly CareersSearchResultsPage careersSearchResultPage;

        public CareersSearchResultsPageActions(IWebDriver driver)
        {
            careersSearchResultPage = new CareersSearchResultsPage(driver);
        }

        public void GoToLatestJobDetailsPage()
        {
            careersSearchResultPage.LoadLatestResult();
            careersSearchResultPage.ClickViewAndApply();
        }
    }
}
