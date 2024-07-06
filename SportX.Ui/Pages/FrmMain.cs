using Microsoft.EntityFrameworkCore;
using SportX.Ui.Models;
using SportX.Ui.Services;

namespace SportX.Ui.Pages;
public partial class FrmMain : Form
{
    private SportXContext _context = new(new DbContextOptions<SportXContext>());
    public FrmMain()
    {
        InitializeComponent();
    }

    private async void ButtonCheck_Click(object sender, EventArgs e)
    {
        string nationalCodeOrId = textBoxNationalCode.Text;
        Athlete athlete = await _context.Athletes
            .FirstOrDefaultAsync(a => a.NationalCode == nationalCodeOrId || a.Id.ToString() == nationalCodeOrId);

        if (athlete != null)
        {
            if (DateTime.TryParseExact(athlete.PaidUntilDate, "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out DateTime paidUntilDate) && paidUntilDate >= DateTime.Today)
            {
                AthleteUsageLog usageLog = new AthleteUsageLog
                {
                    AthleteId = athlete.Id,
                    IsEntered = true,
                    IsPaid = true,
                    CreateDatetime = DateTime.Now
                };

                _context.Usages.Add(usageLog);
                await _context.SaveChangesAsync();

                labelInfo.Text = $"ورود موفق: {athlete.Name}";
                this.BackColor = Color.Green;

                await Task.Delay(10000); // Wait for 10 seconds

                labelInfo.Text = string.Empty;
                this.BackColor = SystemColors.Control;
            }
            else
            {
                MessageBox.Show("تاریخ اعتبار عضویت به پایان رسیده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("ورزشکار یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SignUpMenuItem_Click(object sender, EventArgs e)
    {
        FrmSignup signUpForm = new();
        signUpForm.Show();
    }
}
