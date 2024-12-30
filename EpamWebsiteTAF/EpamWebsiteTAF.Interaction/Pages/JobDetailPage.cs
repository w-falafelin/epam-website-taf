using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class JobDetailPage : BasePage
    {
        private readonly By body = By.TagName("body");

        public JobDetailPage(IWebDriver driver) : base(driver) { }

        public string GetTextFromPage()
        {
            string pageText = FindElement(body).Text;
            return pageText;
        }
    }
}
