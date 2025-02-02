using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class ResponsibleAndGenerativeAIPagesActions
    {
        private readonly ResponsibleAndGenerativeAIPage responsibleAIPage;

        public ResponsibleAndGenerativeAIPagesActions(IWebDriver driver)
        {
            responsibleAIPage = new ResponsibleAndGenerativeAIPage(driver);
        }

        public bool VerifyTitleMatchesExpected(string expectedTitle)
        {
            return responsibleAIPage.IsPageTitleCorrect(expectedTitle);

        }

        public bool VerifyRelatedExpertiseSectionIsPresent()
        {
            return responsibleAIPage.IsRelatedExpertiseSectionPresent();
        }
    }
}
