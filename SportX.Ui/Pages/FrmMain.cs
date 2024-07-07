using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Models;
using SportX.Ui.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        Athlete? athlete = await _context.Athletes
                                         .FirstOrDefaultAsync(a => a.NationalCode == nationalCodeOrId || a.Id.ToString() == nationalCodeOrId);

        if (athlete is not null)
        {
            if (athlete.RemainingSessionCounts > 0)
            {
                AthleteUsageLog usageLog = new AthleteUsageLog
                {
                    AthleteId = athlete.Id,
                    IsEntered = true,
                    IsPaid = true,
                    CreateDatetime = DateTime.Now
                };

                _context.Usages.Add(usageLog);

                athlete.RemainingSessionCounts--;

                _context.Athletes.Update(athlete);

                await _context.SaveChangesAsync();

                MessageBox.Show("ورود ثبت شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadEnteredAthletes();
            }
            else
            {
                MessageBox.Show("اعتبار عضویت به پایان رسیده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("ورزشکار یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SignUpMenuItem_Click(object sender, EventArgs e)
    {
        FrmSignup signUpForm = new();
        signUpForm.Show();
    }

    private void پرداختهاToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmPaymentManagment paymentForm = new();
        paymentForm.Show();
    }

    private async Task LoadEnteredAthletes()
    {
        var enteredAthletes = await _context.Usages.Where(p => p.IsEntered
                                          && PersianCalendarTools.GregorianToPersian(p.CreateDatetime) == PersianCalendarTools.GregorianToPersian(DateTime.Now))
                                                           .Include(p => p.Athlete)
                                                           .ToListAsync();

        var athletes = enteredAthletes.Select(a => new
        {
            a.Athlete.Id,
            a.Athlete.Name,
            a.Athlete.NationalCode,
            Gender = a.Athlete.IsMale ? "مرد" : "زن",
            Membership = a.Athlete.Membership == MembershipType.Normal ? "معمولی" : "نظامی"
        })
        .ToList();

        dataGridViewAthletes.DataSource = athletes;
    }

    private async void FrmMain_Load(object sender, EventArgs e)
    {
        await LoadEnteredAthletes();
    }

    private async void btnExit_Click(object sender, EventArgs e)
    {
        string nationalCodeOrId = textBoxNationalCode.Text;

        if (string.IsNullOrWhiteSpace(nationalCodeOrId))
        {
            MessageBox.Show("لطفا تمام فیلدها را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        await _context.Usages.Where(p => p.IsEntered
                                             && PersianCalendarTools.GregorianToPersian(p.CreateDatetime) == PersianCalendarTools.GregorianToPersian(DateTime.Now)
                                             && (p.AthleteId == int.Parse(textBoxNationalCode.Text)  || p.Athlete.NationalCode == textBoxNationalCode.Text))
                             .ExecuteUpdateAsync(p=>p.SetProperty(prop=>prop.IsEntered , false));

        MessageBox.Show("ورود ثبت شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

        await LoadEnteredAthletes();
    }
}

