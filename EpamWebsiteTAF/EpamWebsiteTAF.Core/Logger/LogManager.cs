using Microsoft.Extensions.Configuration;
using Serilog;

namespace EpamWebsiteTAF.Core.Logger
{
    public static class LogManager
    {
        private static ILogger? logger;

        public static void InitializeLogger()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string configFilePath = Path.Combine(baseDirectory, @"..\..\..\Config\appsettings.json");

            logger = new LoggerConfiguration()
                .ReadFrom.Configuration(new ConfigurationBuilder()
                    .AddJsonFile(configFilePath, optional: false, reloadOnChange: true)
                    .Build())
                .CreateLogger();
        }

        public static void LogInfo(string message) => logger?.Information(message);

        public static void LogError(string message) => logger?.Error(message);

        public static void LogDebug(string message) => logger?.Debug(message);

        public static void LogWarning(string message) => logger?.Warning(message);
    }
}
