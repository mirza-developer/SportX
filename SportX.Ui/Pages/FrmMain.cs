using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Linq;

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
        await CheckAndEnter();
    }

    private void SignUpMenuItem_Click(object sender, EventArgs e)
    {
        timerFocus.Enabled = false;
        buttonEpc.Text = "قرائت";

        FrmSignup signUpForm = new();
        signUpForm.ShowDialog();
        _context.ChangeTracker.Clear();
    }

    private void پرداختهاToolStripMenuItem_Click(object sender, EventArgs e)
    {
        timerFocus.Enabled = false;
        buttonEpc.Text = "قرائت";

        FrmPaymentManagment paymentForm = new();
        paymentForm.ShowDialog();
        _context.ChangeTracker.Clear();
    }

    private async Task LoadEnteredAthletes()
    {
        enteredAthletes = await _context.Usages.Where(p => p.IsEntered
                                                                    && p.CreateDatetime.Date == DateTime.Now.Date)
                                               .OrderBy(p => p.CreateDatetime)
                                               .Include(p => p.Athlete)
                                               .ToListAsync();

        if (!string.IsNullOrEmpty(textBoxSearch.Text))
        {
            enteredAthletes = enteredAthletes.Where(p => p.Id.ToString() == textBoxSearch.Text
            || p.Athlete.Name.Contains(textBoxSearch.Text)
            || p.Athlete.NationalCode.Contains(textBoxSearch.Text)).ToList();
        }

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

    private async Task Exit()
    {
        string nationalCodeOrId = textBoxEnterNationalCode.Text;

        if (string.IsNullOrWhiteSpace(nationalCodeOrId))
        {
            MessageBox.Show("لطفا کد ملی پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return;
        }

        await _context.Usages.Where(p => p.IsEntered
                                             && p.CreateDatetime.Date == DateTime.Now.Date
                                             && (p.AthleteId == int.Parse(textBoxEnterNationalCode.Text) || p.Athlete.NationalCode == textBoxEnterNationalCode.Text))
                             .ExecuteUpdateAsync(p => p.SetProperty(prop => prop.IsEntered, false));

        MessageBox.Show("خروج ثبت شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

        await LoadEnteredAthletes();
    }

    private void dataGridViewAthletes_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridViewAthletes.SelectedRows.Count > 0)
        {
            var selectedId = (int)dataGridViewAthletes.SelectedRows[0].Cells[0].Value;

            textBoxEnterNationalCode.Text = selectedId.ToString();
        }
    }

    private void گزارشماهیانهپرداختToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmPaymentMonthlyReport paymentForm = new();
        paymentForm.Show();
    }

    private void گزارشحضورورزشکارToolStripMenuItem_Click(object sender, EventArgs e)
    {
        timerFocus.Enabled = false;
        buttonEpc.Text = "قرائت";

        FrmAthleteLogReport reportForm = new();
        reportForm.ShowDialog();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void buttonChooseAthlete_Click(object sender, EventArgs e)
    {
        using FrmChooseAthlete frmChooseAthlete = new();

        if (frmChooseAthlete.ShowDialog() == DialogResult.OK)
        {
            textBoxEnterNationalCode.Text = frmChooseAthlete.SelectedAthlete.Id.ToString();
        }
    }

    private async void buttonSearch_Click(object sender, EventArgs e)
    {
        await LoadEnteredAthletes();
    }

    private void timerFocus_Tick(object sender, EventArgs e)
    {
        textBoxEpc.Focus();
    }

    private async void buttonEpc_Click(object sender, EventArgs e)
    {
        if (!timerFocus.Enabled)
        {
            timerFocus.Enabled = true;

            buttonEpc.Text = "توقف";

            textBoxEpc.Text = string.Empty;
        }
        else
        {
            timerFocus.Enabled = false;

            buttonEpc.Text = "قرائت";
        }
    }

    private async void textBoxEpc_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (!string.IsNullOrEmpty(textBoxEpc.Text))
            {
                await CheckAndEnter();

                textBoxEpc.Text = string.Empty;
            }
        }
    }

    private void LoadAthleteInfo(Athlete athlete)
    {
        textBoxName.Text = athlete.Name;
        textBoxNationalCode.Text = athlete.NationalCode;
        textBoxPhone.Text = athlete.Phone;
        textBoxId.Text = athlete.Id.ToString();
        textBoxAddress.Text = athlete.Address;
        textboxRemainingSessions.Text = athlete.RemainingSessionCounts.ToString();
        textBoxEndDate.Text = athlete.DateEndMembership;
    }

    private async Task CheckAndEnter()
    {
        string nationalCodeOrId = textBoxEnterNationalCode.Text;

        Athlete? athlete;

        if (!string.IsNullOrEmpty(textBoxEpc.Text))
        {
            athlete = await _context.Athletes
                                    .FirstOrDefaultAsync(a => a.Epc == textBoxEpc.Text);
        }
        else
        {


            athlete = await _context.Athletes
                                    .FirstOrDefaultAsync(a => a.NationalCode == nationalCodeOrId || a.Id.ToString() == nationalCodeOrId);
        }

        if (enteredAthletes.Any(p => p.AthleteId == athlete.Id))
        {
            await Exit();

            return;
        }

        LoadAthleteInfo(athlete);

        if (athlete is not null)
        {
            if (athlete.RemainingSessionCounts > 0)
            {
                if (PersianCalendarTools.PersianToGregorian(athlete.DateEndMembership).Date < DateTime.Now.Date)
                {
                    textBoxStatus.Text = "اتمام تاریخی اعتبار";

                    groupBoxInfo.BackColor = Color.Red;

                    timerClearInfo.Enabled = true;

                    return;
                }

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

                textBoxStatus.Text = "ورود موفق";

                groupBoxInfo.BackColor = Color.Green;

                await LoadEnteredAthletes();
            }
            else
            {
                textBoxStatus.Text = "اتمام جلسه ای اعتبار";

                groupBoxInfo.BackColor = Color.Red;
            }

            timerClearInfo.Enabled = true;
        }
        else
        {
            MessageBox.Show("ورزشکار یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void timerClearInfo_Tick(object sender, EventArgs e)
    {
        groupBoxInfo.BackColor = SystemColors.Control;

        foreach (var control in groupBoxInfo.Controls)
        {
            if (control is TextBox textbox)
            {
                textbox.Text = string.Empty;
            }
        }

        timerClearInfo.Enabled = false;
    }
}

