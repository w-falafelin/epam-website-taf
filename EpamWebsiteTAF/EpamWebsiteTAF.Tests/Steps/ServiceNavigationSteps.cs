using EpamWebsiteTAF.Core.Logger;
using EpamWebsiteTAF.Core;
using EpamWebsiteTAF.Interaction.Actions;
using TechTalk.SpecFlow;

namespace EpamWebsiteTAF.Tests.Steps;

[Binding]
public class ServicesNavigationSteps
{
    private readonly HomePageActions homePageActions;
    private readonly ResponsibleAndGenerativeAIPagesActions aiPageActions;

    public ServicesNavigationSteps()
    {
        homePageActions = new HomePageActions(DriverManager.WebDriver);
        aiPageActions = new ResponsibleAndGenerativeAIPagesActions(DriverManager.WebDriver);
    }

    [Given(@"I am on the EPAM homepage")]
    public void GivenIAmOnTheEPAMHomepage()
    {
        homePageActions.AcceptCookies();
        LogManager.LogInfo("User is on the EPAM homepage.");
    }

    [When(@"I navigate to the ""(.*)"" section")]
    public void WhenINavigateToTheSection(string section)
    {
        homePageActions.HoverOverServicesLink();
        LogManager.LogInfo($"Navigated to the '{section}' section.");
    }

    [When(@"I select the ""(.*)"" category from the dropdown")]
    public void WhenISelectTheCategoryFromTheDropdown(string category)
    {
        homePageActions.ClickLinkByText(category);
        LogManager.LogInfo($"Selected the '{category}' category from the dropdown.");
    }

    [Then(@"the page title should contain ""(.*)""")]
    public void ThenThePageTitleShouldContain(string expectedTitle)
    {
        var isExpectedTitleCorrect = aiPageActions.VerifyTitleMatchesExpected(expectedTitle);
        Assert.That(isExpectedTitleCorrect, Is.True);
        LogManager.LogInfo($"Page title validation passed. The title contains: '{expectedTitle}'.");
    }

    [Then(@"the ""(.*)"" section should be displayed")]
    public void ThenTheSectionShouldBeDisplayed(string sectionName)
    {
        var isSectionPresent = aiPageActions.VerifyRelatedExpertiseSectionIsPresent();
        Assert.That(isSectionPresent, Is.True);
        LogManager.LogInfo($"Validation passed. The '{sectionName}' section is displayed on the page.");
    }
}
