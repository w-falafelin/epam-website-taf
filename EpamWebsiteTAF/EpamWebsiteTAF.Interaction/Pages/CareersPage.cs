using OpenQA.Selenium;

namespace EpamWebsiteTAF.Interaction.Pages
{
    public class CareersPage : BasePage
    {
        private readonly By keywordField = By.Id("new_form_job_search-keyword");
        private readonly By locationDropdown = By.CssSelector("span.select2-selection.select2-selection--single[role='combobox']");
        private readonly By findButton = By.XPath("//button[contains(text(), 'Find')]");
        private static By Checkbox(string name) => By.Name($"{name}");
        private static By LocationOption(string location) => By.XPath($"//li[@title='{location}']");

        public CareersPage(IWebDriver driver) : base(driver) { }

        public void FillInKeywordInput(string keyword)
        {
            var field = FindElement(keywordField);
            field.Clear();
            field.SendKeys(keyword);
        }

        public void ClickOnLocationDropdown() => FindElement(locationDropdown).Click();

        public void SelectLocationOption(string location)
        {
            FindElement(locationDropdown).Click();
            FindElement(LocationOption(location)).Click();
        }

        public void SelectCheckbox(string name, bool shouldSelect)
        {
            var checkbox = FindElement(Checkbox(name));
            bool isSelected = checkbox.Selected;

            if (isSelected != shouldSelect)
            {
                ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", checkbox);
            }
        }

        public void ClickFindButton() => FindElement(findButton).Click();
    }
}
