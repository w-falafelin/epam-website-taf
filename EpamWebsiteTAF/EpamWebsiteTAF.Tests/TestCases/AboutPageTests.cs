using EpamWebsiteTAF.Core;
using EpamWebsiteTAF.Core.Logger;
using EpamWebsiteTAF.Core.Utilities;
using EpamWebsiteTAF.Interaction.Actions;

namespace EpamWebsiteTAF.Tests.TestCases
{
    [TestFixture]
    public class AboutPageTests : BaseTest
    {
        private HomePageActions homePageActions;
        private AboutPageActions aboutPageActions;

        [SetUp]
        public void TestSetup()
        {
            homePageActions = new HomePageActions(DriverManager.WebDriver);
            aboutPageActions = new AboutPageActions(DriverManager.WebDriver);
        }

        [Test]
        [TestCase("EPAM_Corporate_Overview_Q4_EOY.pdf")]
        public void TC_3_DownloadFunctionWorksAsExpected(string fileName)
        {
            homePageActions.AcceptCookies();
            homePageActions.ClickAboutLink();

            aboutPageActions.DownloadFile();

            var downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            aboutPageActions.VerifyFileIsDownloaded(downloadsPath, fileName);

            FileHelper.DeleteDownloadedFile(downloadsPath, fileName);
        }
    }
}
