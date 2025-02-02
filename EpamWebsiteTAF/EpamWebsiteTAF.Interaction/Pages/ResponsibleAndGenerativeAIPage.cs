using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class ResponsibleAndGenerativeAIPage : BasePage
    {
        private readonly By ourRelatedExpertiseSection = By.XPath("//span[contains(text(), 'Our Related Expertise')]/ancestor::div[@class='section']");

        public ResponsibleAndGenerativeAIPage(IWebDriver driver) : base(driver) { }

        public bool IsPageTitleCorrect(string expectedTitle)
        {
            return ValidatePageTitle(expectedTitle);
        }

        public bool IsRelatedExpertiseSectionPresent()
        {
            return IsElementPresent(ourRelatedExpertiseSection);
        }
    }
}
