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
    private bool isExiting = false;

    public FrmMain()
    {
        InitializeComponent();
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

    private async Task Exit(Athlete athlete)
    {

        await _context.Usages.Where(p => p.IsEntered
                                             && p.CreateDatetime.Date == DateTime.Now.Date
                                             && (p.AthleteId == athlete.Id))
                             .ExecuteUpdateAsync(p => p.SetProperty(prop => prop.IsEntered, false));

        MessageBox.Show("خروج ثبت شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);

        await LoadEnteredAthletes();
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
        // If already in the process of exiting, don't show dialog again
        if (isExiting)
        {
            return;
        }

        var result = MessageBox.Show(
            "آیا قبل از خروج، پشتیبان از پایگاه داده تهیه شود؟",
            "پشتیبان گیری از پایگاه داده",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        switch (result)
        {
            case DialogResult.Yes:
                e.Cancel = true;
                isExiting = true; // Set flag to prevent loop
                _ = PerformBackup(true); // Exit after backup
                break;

            default:
                isExiting = true; // Set flag before exit
                Application.Exit();
                break;
        }
    }

    private async Task PerformBackup(bool exitAfterBackup = false)
    {
        try
        {
            // Get backup path from configuration
            var backupPath = Program.Configuration["ProjectConfigs:BackupSettings:BackupPath"];

            if (string.IsNullOrEmpty(backupPath))
            {
                MessageBox.Show(
                    "مسیر پشتیبان گیری در تنظیمات تعریف نشده است.",
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                if (exitAfterBackup)
                {
                    isExiting = true;
                    Application.Exit();
                }
                return;
            }

            // Create backup directory if it doesn't exist
            if (!Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(backupPath);
            }

            // Generate backup file name with Persian date and time
            var now = DateTime.Now;
            var persianDate = PersianCalendarTools.GregorianToPersianWithManualSeprator(now, "-");
            var persianTime = now.ToString("HH-mm-ss");
            var fileName = $"SportX_Backup_{persianDate}_{persianTime}.bak";
            var fullBackupPath = Path.Combine(backupPath, fileName);

            // Create and show progress form
            var progressForm = new Form();
            var progressLabel = new Label();
            progressLabel.Text = "در حال تهیه پشتیبان، لطفا صبر کنید...";
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(20, 20);
            progressForm.Controls.Add(progressLabel);
            progressForm.Size = new Size(300, 100);
            progressForm.StartPosition = exitAfterBackup ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;
            progressForm.Text = "پشتیبان گیری";
            progressForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            progressForm.MaximizeBox = false;
            progressForm.MinimizeBox = false;
            progressForm.Show();
            Application.DoEvents();

            // Perform backup
            bool backupSuccess = await _context.CreateBackupAsync(fullBackupPath);

            // Close progress form
            progressForm.Close();

            // Show result message
            if (backupSuccess)
            {
                MessageBox.Show(
                    $"پشتیبان با موفقیت در مسیر زیر ذخیره شد:\n{fullBackupPath}",
                    "پشتیبان گیری موفق",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "خطا در تهیه پشتیبان رخ داد. لطفا دوباره تلاش کنید.",
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                if (exitAfterBackup)
                {
                    isExiting = true;
                    Application.Exit();
                }
                return;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"خطا در تهیه پشتیبان: {ex.Message}",
                "خطا",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            
            if (exitAfterBackup)
            {
                isExiting = true;
                Application.Exit();
            }
            return;
        }

        // Exit application if requested and backup was successful
        if (exitAfterBackup)
        {
            isExiting = true;
            Application.Exit();
        }
    }

    private void buttonChooseAthlete_Click(object sender, EventArgs e)
    {
        using FrmChooseAthlete frmChooseAthlete = new();

        if (frmChooseAthlete.ShowDialog() == DialogResult.OK)
        {
            if (enteredAthletes.Any(p => p.Id == frmChooseAthlete.SelectedAthlete.Id))
            {
                foreach (DataGridViewRow row in dataGridViewAthletes.Rows)
                {
                    if (row.Cells["Id"].Value.ToString() == frmChooseAthlete.SelectedAthlete.Id.ToString())
                    {
                        row.Selected = true;

                        break;
                    }
                }
            }
            else
            {
            }
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

            textBoxEpc.ReadOnly = false;
        }
        else
        {
            timerFocus.Enabled = false;

            buttonEpc.Text = "قرائت";

            textBoxEpc.ReadOnly = true;
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
        if (string.IsNullOrEmpty(textBoxEpc.Text))
        {
            return;
        }

        Athlete? athlete = athlete = await _context.Athletes
                                    .FirstOrDefaultAsync(a => a.Epc == textBoxEpc.Text);


        if (enteredAthletes.Any(p => p.AthleteId == athlete.Id))
        {
            await Exit(athlete);

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

    private void مدیریتبرنامههاToolStripMenuItem_Click(object sender, EventArgs e)
    {
        timerFocus.Enabled = false;
        buttonEpc.Text = "قرائت";

        FrmPlanManagment reportForm = new();
        reportForm.ShowDialog();
    }

    private async void تهیهپشتیبانToolStripMenuItem_Click(object sender, EventArgs e)
    {
        await PerformBackup(false); // Don't exit after backup
    }
}

