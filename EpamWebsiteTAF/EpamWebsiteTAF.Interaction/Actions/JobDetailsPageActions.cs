using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class JobDetailsPageActions
    {
        private readonly JobDetailPage jobDetailPage;

        public JobDetailsPageActions(IWebDriver driver)
        {
            jobDetailPage = new JobDetailPage(driver);
        }

        public bool VerifyKeywordIsMentionedOnPage(string keyword)
        {
            string pageText = jobDetailPage.GetTextFromPage();
            return pageText.Contains(keyword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
