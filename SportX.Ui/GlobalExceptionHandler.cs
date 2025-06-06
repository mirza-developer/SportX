using System.Diagnostics;

namespace SportX.Ui;
public static class GlobalExceptionHandler
{
    public static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Exception? ex = e.ExceptionObject as Exception;

        HandleException(ex, "AppDomain.CurrentDomain.UnhandledException");
    }

    private static void HandleException(Exception? ex, string source)
    {
#if DEBUG
        Debugger.Break();
#endif
        Log.Fatal(ex, ex.Message);

        MessageBox.Show(
            $"An unexpected error occurred:\n{ex?.Message}",
            "توجه",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
    }
}
