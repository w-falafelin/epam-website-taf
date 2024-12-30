using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class CareersPageActions
    {
        private readonly CareersPage careersPage;

        public CareersPageActions(IWebDriver driver)
        {
            careersPage = new CareersPage(driver);
        }

        public void EnterKeyword(string keyword)
        {
            careersPage.FillInKeywordInput(keyword);
        }

        public void SelectLocation(string location)
        {
            careersPage.SelectLocationOption(location);
        }

        public void SelectCheckboxes(bool selectRemote = false, bool selectOffice = false, bool selectRelocation = false)
        {
            careersPage.SelectCheckbox("remote", selectRemote);
            careersPage.SelectCheckbox("office", selectOffice);
            careersPage.SelectCheckbox("relocation", selectRelocation);
        }

        public void PerformSearch()
        {
            careersPage.ClickFindButton();
        }
    }
}
