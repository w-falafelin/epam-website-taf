using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class ResponsibleAIPage : BasePage
    {
        private readonly By ourRelatedExpertiseSection = By.XPath("//span[contains(text(), 'Our Related Expertise')]/ancestor::div[@class='section']");

        public ResponsibleAIPage(IWebDriver driver) : base(driver) { }

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
