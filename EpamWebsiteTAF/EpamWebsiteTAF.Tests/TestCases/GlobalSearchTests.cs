using EpamWebsiteTAF.Core;
using EpamWebsiteTAF.Interaction.Actions;

namespace EpamWebsiteTAF.Tests.TestCases
{
    [TestFixture]
    public class GlobalSearchTests : BaseTest
    {
        private HomePageActions homePageActions;
        private GlobalSearchResultsPageActions globalSearchResultsPageActions;

        [SetUp]
        public void TestSetup()
        {
            homePageActions = new HomePageActions(DriverManager.WebDriver);
            globalSearchResultsPageActions = new GlobalSearchResultsPageActions(DriverManager.WebDriver);
        }

        [Test]
        [TestCase("Retail")]
        [TestCase("Automation")]
        public void TC_2_GlobalSearchWorksAsExpected(string searchQuery)
        {
            homePageActions.AcceptCookies();
            homePageActions.EnterQueryAndPerformSearch(searchQuery);

            var containText = globalSearchResultsPageActions.VerifyAllSearchResultsContainText(searchQuery);

            Assert.That(containText, Is.True);
        }
    }
}
