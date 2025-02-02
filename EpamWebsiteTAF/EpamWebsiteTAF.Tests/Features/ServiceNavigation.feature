Feature: Services Section Navigation
    As a user,
    I want to navigate to the Services section from the main navigation menu,
    So that I can explore different service categories.

    Scenario: Validate Navigation to Services Section
        Given I am on the EPAM homepage
        When I navigate to the "Services" section
        And I select the "<ServiceCategory>" category from the dropdown
        Then the page title should contain "<ExpectedTitle>"
        And the "Our Related Expertise" section should be displayed

        Examples:
        | ServiceCategory | ExpectedTitle  |
        | Generative AI   | Generative AI  |
        | Responsible AI  | Responsible AI |
