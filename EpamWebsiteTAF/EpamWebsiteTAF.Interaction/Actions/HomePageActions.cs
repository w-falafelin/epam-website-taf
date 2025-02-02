using EpamWebsiteTAF.Interaction.Pages;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Actions
{
    public class HomePageActions
    {
        private readonly HomePage homePage;

        public HomePageActions(IWebDriver driver)
        {
            homePage = new HomePage(driver);
        }

        public void ClickCareersLink() => homePage.ClickLinkByItsText("Careers");

        public void ClickAboutLink() => homePage.ClickLinkByItsText("About");

        public void ClickIsightsLink() => homePage.ClickLinkByItsText("Insights");

        public void ClickLinkByText(string text) => homePage.ClickLinkByItsText(text);

        public void HoverOverServicesLink() => homePage.MouseHoverOnLinkByItsText("Services");

        public void EnterQueryAndPerformSearch(string query)
        {
            homePage.ClickSearchIcon();
            homePage.EnterSearchQuery(query);
            homePage.CLickFindButton();
        }

        public void AcceptCookies()
        {
            homePage.AcceptAllCookies();
        }
    }
}
