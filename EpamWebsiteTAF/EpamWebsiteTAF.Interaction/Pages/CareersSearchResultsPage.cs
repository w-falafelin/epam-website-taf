using OpenQA.Selenium;
using EpamWebsiteTAF.Core.Utilities;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class CareersSearchResultsPage : BasePage
    {
        private readonly By viewAndApplyButton = By.XPath("(//a[contains(text(), 'View and apply')])[last()]");
        private readonly By viewMoreButton = By.XPath("//a[contains(text(), 'View More')]");

        public CareersSearchResultsPage(IWebDriver driver) : base(driver) { }

        public void LoadLatestResult()
        {
            var latestResultBeforeScroll = FindElement(viewAndApplyButton);
            ScrollToElement(latestResultBeforeScroll);
            WaitHelper.WaitForElementToBeVisible(Driver, viewMoreButton);
        }

        public void ClickViewAndApply()
        {
            FindElement(viewAndApplyButton).Click();
        }
    }
}
