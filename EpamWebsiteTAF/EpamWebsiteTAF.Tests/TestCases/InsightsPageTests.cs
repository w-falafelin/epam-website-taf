using EpamWebsiteTAF.Core;
using EpamWebsiteTAF.Interaction.Actions;

namespace EpamWebsiteTAF.Tests.TestCases
{
    [TestFixture]
    public class InsightsPageTests : BaseTest
    {
        private HomePageActions homePageActions;
        private InsightsPageActions insightsPageActions;
        private InsightsArticleActions insightsArticleActions;

        [SetUp]
        public void TestSetup()
        {
            homePageActions = new HomePageActions(DriverManager.WebDriver);
            insightsPageActions = new InsightsPageActions(DriverManager.WebDriver);
            insightsArticleActions = new InsightsArticleActions(DriverManager.WebDriver);
        }

        [Test]
        public void TC_4_ArticleTitleMatchesTitleInCarousel()
        {
            homePageActions.AcceptCookies();
            homePageActions.ClickIsightsLink();

            var expectedTitle = insightsPageActions.SwipeCarouselAndOpenArticle(2);
            var isMatching = insightsArticleActions.VerifyArticlesTitleMatchesExpected(expectedTitle);

            Assert.That(isMatching, Is.True);
        }
    }
}
