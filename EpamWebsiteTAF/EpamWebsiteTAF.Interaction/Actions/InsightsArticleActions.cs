using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class InsightsArticleActions
    {
        private readonly InsightsArticle insightsArticle;

        public InsightsArticleActions(IWebDriver driver)
        {
            insightsArticle = new InsightsArticle(driver);
        }

        public bool VerifyArticlesTitleMatchesExpected(string expectedTitle)
        {
            var actualTitle = insightsArticle.GetArticleTitle();

            return string.Equals(actualTitle, expectedTitle, StringComparison.OrdinalIgnoreCase);
        }
    }
}
