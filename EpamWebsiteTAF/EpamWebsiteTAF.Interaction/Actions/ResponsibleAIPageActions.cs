using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class ResponsibleAIPageActions
    {
        private readonly ResponsibleAIPage responsibleAIPage;

        public ResponsibleAIPageActions(IWebDriver driver)
        {
            responsibleAIPage = new ResponsibleAIPage(driver);
        }

        public bool VerifyTitleMatchesExpected(string expectedTitle)
        {
            return responsibleAIPage.IsPageTitleCorrect(expectedTitle);
        }
    }
}
