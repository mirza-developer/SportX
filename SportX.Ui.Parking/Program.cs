using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace SportX.Ui.Parking
{
    internal static class Program
    {
        public static IConfiguration Configuration;

        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}