using Microsoft.Extensions.Configuration;
using Serilog;

namespace SportX.Ui;
internal static class Program
{
    public static IConfiguration Configuration;

    [STAThread]
    static void Main()
    {
        AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler.CurrentDomain_UnhandledException;

        Configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(Configuration)
            .CreateLogger();

        try
        {
            Log.Information("Application Starting Up");
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application start-up failed");
            throw;
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}