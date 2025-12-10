using AirportApp.Forms;
using AirportApp.Services;
using Microsoft.Extensions.Logging;
using Serilog;

namespace AirportApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Настройка Serilog
            var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Seq(
                    serverUrl: "http://localhost:5341",
                    apiKey: "sBYcHWoX3lfUWvMS5ngK"
                )
                .CreateLogger();

            // Регистрация ILoggerFactory с Serilog
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilog(serilogLogger);
            });

            // Создаём хранилище
            var storage = new InMemoryFlightStorage();

            // Создаём FlightService с правильными зависимостями
            var flightService = new FlightService(storage, loggerFactory);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(flightService));
        }
    }
}