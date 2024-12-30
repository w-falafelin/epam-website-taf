using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class InsightsPage : BasePage
    {
        private readonly By rightArrowButton = By.XPath("//button[@class='slider__right-arrow slider-navigation-arrow']");
        private readonly By readMoreButton = By.XPath("//div[@class='slider section'][1]//div[@aria-hidden='false']//div[@data-link-name='Read More']//a");
        private readonly By articleName = By.XPath("//div[@class='slider section'][1]//div[@aria-hidden='false']//div[@class='text'][last()]//p");

        public InsightsPage(IWebDriver driver) : base(driver) { }

        public void ClickReadMoreButton()
        {
            FindElement(readMoreButton).Click();
        }

        public string GetArticleTitle()
        {
            var paragraphElement = FindElement(articleName);
            return paragraphElement.Text.Trim();
        }

        public void ClickRightArrowButton()
        {
            MoveToElementAndClick(rightArrowButton);
        }
    }
}
