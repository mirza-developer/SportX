using Microsoft.Extensions.Configuration;

namespace SportX.Ui;
internal static class Program
{
    public static IConfiguration Configuration;

    [STAThread]
    static void Main()
    {
        var builder = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        ApplicationConfiguration.Initialize();

        Application.Run(new FrmLogin());
    }
}