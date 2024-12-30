using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class InsightsPageActions
    {
        private readonly InsightsPage insightsPage;

        public InsightsPageActions(IWebDriver driver)
        {
            insightsPage = new InsightsPage(driver);
        }

        public void ClickRightArrowMultipleTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                insightsPage.ClickRightArrowButton();
                Thread.Sleep(1000);
            }
        }

        public string SwipeCarouselAndOpenArticle(int times)
        {
            ClickRightArrowMultipleTimes(times);

            var articleTitle = insightsPage.GetArticleTitle();

            insightsPage.ClickReadMoreButton();

            return articleTitle;
        }
    }
}
