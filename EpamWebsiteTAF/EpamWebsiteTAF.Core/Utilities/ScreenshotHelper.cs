using EpamWebsiteTAF.Core.Logger;
using OpenQA.Selenium;

namespace EpamWebsiteTAF.Core.Utilities
{
    public static class ScreenshotHelper
    {
        public static string TakeScreenshot(IWebDriver driver, string testName)
        {
            try
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                var screenshotsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");

                if (!Directory.Exists(screenshotsDirectory))
                {
                    Directory.CreateDirectory(screenshotsDirectory);
                }

                var fileName = $"{testName}_{timestamp}.png";
                var filePath = Path.Combine(screenshotsDirectory, fileName);

                screenshot.SaveAsFile(filePath);
                LogManager.LogInfo($"Screenshot saved at: {filePath}");

                return filePath;
            }
            catch (Exception ex)
            {
                LogManager.LogError($"Failed to take screenshot: {ex.Message}");
                Console.WriteLine($"Failed to take screenshot: {ex.Message}");

                return string.Empty;
            }
        }
    }
}
