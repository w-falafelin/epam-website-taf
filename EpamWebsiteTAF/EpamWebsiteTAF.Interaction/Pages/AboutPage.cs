using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class AboutPage : BasePage
    {
        private readonly By epamAtAGlanceSection = By.XPath("//div//span[contains(text(), 'EPAM at')]");
        private readonly By DownloadButton = By.XPath("//a//span[contains(@class, 'button__content--desktop') and contains(text(), 'DOWNLOAD')]");

        public AboutPage(IWebDriver driver) : base(driver) { }

        public void ScrollToEpamAtAGlance()
        {
            var section = FindElement(epamAtAGlanceSection);
            ScrollToElement(section);
        }

        public void ClickDownloadButton()
        {
            FindElement(DownloadButton).Click();
        }
    }
}
