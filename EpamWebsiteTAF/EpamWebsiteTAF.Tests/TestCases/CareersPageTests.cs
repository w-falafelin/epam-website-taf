using EpamWebsiteTAF.Core;
using EpamWebsiteTAF.Interaction.Actions;

namespace EpamWebsiteTAF.Tests.TestCases
{
    [TestFixture]
    public class CareersPageTests : BaseTest
    {
        private HomePageActions homePageActions;
        private CareersPageActions careersPageActions;
        private CareersSearchResultsPageActions careersSearchResultsPageActions;
        private JobDetailsPageActions jobDetailsPageActions;

        [SetUp]
        public void TestSetup()
        {
            homePageActions = new HomePageActions(DriverManager.WebDriver);
            careersPageActions = new CareersPageActions(DriverManager.WebDriver);
            careersSearchResultsPageActions = new CareersSearchResultsPageActions(DriverManager.WebDriver);
            jobDetailsPageActions = new JobDetailsPageActions(DriverManager.WebDriver);
        }

        [Test]
        [TestCase("Java", "All Locations")]
        public void TC_1_KeywordFromSearchIsMentionedOnPage(string keyword, string location)
        {
            homePageActions.AcceptCookies();
            homePageActions.ClickCareersLink();

            careersPageActions.EnterKeyword(keyword);
            careersPageActions.SelectLocation(location);
            careersPageActions.SelectCheckboxes(selectRemote:  true);
            careersPageActions.PerformSearch();

            careersSearchResultsPageActions.GoToLatestJobDetailsPage();

            var isMentioned = jobDetailsPageActions.VerifyKeywordIsMentionedOnPage(keyword);

            Assert.That(isMentioned, Is.True);
        }
    }
}
