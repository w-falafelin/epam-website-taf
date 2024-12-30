namespace EpamWebsiteTAF.Core.Utilities
{
    public static class FileHelper
    {
        public static bool WaitForFileDownload(string downloadPath, string fileName, int timeoutInSeconds = 30)
        {
            var timeout = TimeSpan.FromSeconds(timeoutInSeconds);
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            while (stopwatch.Elapsed < timeout)
            {
                var filePath = Path.Combine(downloadPath, fileName);
                if (File.Exists(filePath))
                {
                    return true;
                }

                Thread.Sleep(500);
            }

            return false;
        }

        public static bool IsFileDownloaded(string downloadPath, string fileName)
        {
            return Directory.GetFiles(downloadPath).Any(file => file.Contains(fileName));
        }

        public static void DeleteDownloadedFile(string downloadPath, string fileName)
        {
            var isFileDownloaded = IsFileDownloaded(downloadPath, fileName);

            if (isFileDownloaded)
            {
                var filePath = Path.Combine(downloadPath, fileName);
                File.Delete(filePath);
            }
        }
    }
}
