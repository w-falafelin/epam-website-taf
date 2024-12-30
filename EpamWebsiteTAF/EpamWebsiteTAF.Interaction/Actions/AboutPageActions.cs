using EpamWebsiteTAF.Interaction.Pages;
using EpamWebsiteTAF.Core.Utilities;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class AboutPageActions
    {
        private readonly AboutPage aboutPage;

        public AboutPageActions(IWebDriver driver)
        {
            aboutPage = new AboutPage(driver);
        }

        public void DownloadFile()
        {
            aboutPage.ScrollToEpamAtAGlance();
            aboutPage.ClickDownloadButton();
        }

        public bool VerifyFileIsDownloaded(string downloadPath, string fileName)
        {
            FileHelper.WaitForFileDownload(downloadPath, fileName);
            return FileHelper.IsFileDownloaded(downloadPath, fileName);
        }
    }
}
