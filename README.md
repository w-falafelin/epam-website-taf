# EPAM Website Test Automation Framework

## Overview
This is a portable Test Automation Framework built using C#, Selenium, and NUnit. It is designed to automate the testing of the EPAM website and supports robust features such as logging, screenshot capturing on test failures, and file download verification.

## Project structure
```
EpamWebsiteTAF
├── EpamWebsiteTAF.Core           # Core functionality of the framework
│   ├── Logger
│   │   └── LogManager.cs         # Centralized logging using Serilog
│   ├── Utilities
│   │   ├── FileHelper.cs         # Verifies file downloads
│   │   ├── ScreenshotHelper.cs   # Captures screenshots on test failures
│   │   ├── WaitHelper.cs         # Explicit wait helper methods
│   ├── BrowserFactory.cs         # Factory pattern for WebDriver initialization
│   ├── BrowserType.cs            # Enum for supported browsers
│   └── DriverManager.cs          # Handles WebDriver lifecycle
│
├── EpamWebsiteTAF.Interaction    # Business layer for actions and page objects
│   ├── Actions
│   │   ├── AboutPageActions.cs
│   │   ├── CareersPageActions.cs
│   │   ├── CareersSearchResultsPageActions.cs
│   │   ├── GlobalSearchResultsPageActions.cs
│   │   ├── HomePageActions.cs
│   │   ├── InsightsArticleActions.cs
│   │   └── JobDetailsPageActions.cs
│   ├── Pages
│   │   └── <PageObjectFiles>.cs  # Page Object Models (POMs)
│
├── EpamWebsiteTAF.Tests          # Test layer containing test cases and configurations
│   ├── Config
│   │   └── appsettings.json      # Configuration file for base URL and logging levels
│   ├── TestCases
│   │   ├── AboutPageTests.cs     # Test cases for About Page
│   │   ├── CareersPageTests.cs   # Test cases for Careers Page
│   │   ├── GlobalSearchTests.cs  # Test cases for Global Search
│   │   ├── InsightsPageTests.cs  # Test cases for Insights Page
│   └── BaseTest.cs               # Base test class for setup and teardown

```

## Setup Instructions
### Prerequisites
- Install Visual Studio.
- Add the following NuGet packages to your solution:
    - Selenium.WebDriver
    - Selenium.WebDriver.ChromeDriver
    - NUnit
    - Serilog and Serilog.Sinks.File (for logging)

## Running Tests
### Using Visual Studio
1. Open the solution in Visual Studio.
2. Navigate to Test Explorer.
3. Run specific tests or all tests.

## Key Features

1. Factory Design Pattern: WebDriver initialization using a flexible factory pattern.
2. Logging: Integrated with Serilog for structured logging to console and file.
3. Screenshot on Failure: Screenshots are saved automatically when tests fail.
4. Portable Design: Works across different environments and manages downloads and logs dynamically.
