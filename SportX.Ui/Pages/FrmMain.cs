using Microsoft.EntityFrameworkCore;
using SportX.Ui.Models;
using SportX.Ui.Services;

namespace SportX.Ui.Pages;
public partial class FrmMain : Form
{
    private SportXContext _context = new(new DbContextOptions<SportXContext>());
    private List<AthleteUsageLog>? enteredAthletes;

    public FrmMain()
    {
        InitializeComponent();
    }

    private async void ButtonCheck_Click(object sender, EventArgs e)
    {
        string nationalCodeOrId = textBoxNationalCode.Text;

        Athlete? athlete = await _context.Athletes
                                         .FirstOrDefaultAsync(a => a.NationalCode == nationalCodeOrId || a.Id.ToString() == nationalCodeOrId);

        if (enteredAthletes.Any(p=> p.AthleteId == athlete.Id))
        {
            MessageBox.Show("ورزشکار وارد شده است", "توجه" ,MessageBoxButtons.OK , MessageBoxIcon.Warning);

            return;
        }

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
        enteredAthletes = await _context.Usages.Where(p => p.IsEntered
                                                                    && p.CreateDatetime.Date == DateTime.Now.Date)
                                               .Include(p => p.Athlete)
                                               .ToListAsync();

        var athletes = enteredAthletes.Select(a => new
        {
            کد = a.Athlete.Id,
            نام = a.Athlete.Name,
            کدملی = a.Athlete.NationalCode,
            جنسیت = a.Athlete.IsMale ? "مرد" : "زن",
            عضویت = a.Athlete.Membership == MembershipType.Normal ? "معمولی" : "نظامی",
            ورود = a.CreateDatetime.ToString("HH:mm")
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
                                             && p.CreateDatetime.Date == DateTime.Now.Date
                                             && (p.AthleteId == int.Parse(textBoxNationalCode.Text) || p.Athlete.NationalCode == textBoxNationalCode.Text))
                             .ExecuteUpdateAsync(p => p.SetProperty(prop => prop.IsEntered, false));

        MessageBox.Show("خروج ثبت شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

        await LoadEnteredAthletes();
    }

    private void dataGridViewAthletes_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridViewAthletes.SelectedRows.Count > 0)
        {
            var selectedId = (int)dataGridViewAthletes.SelectedRows[0].Cells[0].Value;

            textBoxNationalCode.Text = selectedId.ToString();
        }
    }
}

