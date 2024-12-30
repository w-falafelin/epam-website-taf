using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class InsightsArticle : BasePage
    {
        private readonly By articleTitle = By.XPath("//div[@class='text']//span[contains(@class, 'font-size-80-33')]");

        public InsightsArticle(IWebDriver driver) : base(driver) { }

        public string GetArticleTitle()
        {
            return FindElement(articleTitle).Text.Trim();
        }
    }
}
