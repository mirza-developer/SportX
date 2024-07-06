using SportX.Ui.Pages;
using SportX.Ui.Services;

namespace SportX.Ui;
public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
        string username = textBoxUsername.Text;

        string password = textBoxPassword.Text;

        if (AuthenticationService.IsAdminAuthenticate(username, password)
            || AuthenticationService.IsMaleUserAuthenticate(username, password)
            || AuthenticationService.IsFemaleUserAuthenticate(username, password))
        {
            new FrmMain().Show();

            this.Hide();
        }
        else
        {
            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
