using Microsoft.EntityFrameworkCore;
using SportX.Ui.Models;
using SportX.Ui.Services;

namespace SportX.Ui.Pages;
public partial class FrmSignup : Form
{
    private SportXContext context = new();
    private Athlete _selectedAthlete;
    public FrmSignup()
    {
        InitializeComponent();

        LoadAthletes();
    }

    private void LoadAthletes()
    {
        var athletes = context.Athletes
            .Include(a => a.Payments)
            .ThenInclude(p => p.Plan)
            .AsQueryable();

        if (!string.IsNullOrEmpty(textBoxSearch.Text))
        {
            athletes = athletes.Where(p => p.Id.ToString() == textBoxSearch.Text
            || p.Name.Contains(textBoxSearch.Text)
            || p.NationalCode.Contains(textBoxSearch.Text));
        }

        var athleteList = athletes.ToList().Select(a => new
        {
            a.Id,
            a.Name,
            a.NationalCode,
            a.Phone,
            a.DateOfBirth,
            MembershipString = a.MembershipString,
            GenderString = a.GenderString,
            RemainingSessionCounts = a.RemainingSessionCounts,
            a.Address,
            DateEndMembership = a.DateEndMembership ?? "نامشخص",
            CurrentPlan = a.Payments
                .OrderByDescending(p => p.CreateDatetime)
                .FirstOrDefault()?.Plan?.Title ?? "هیچ برنامه ای",
            a.CreateDatetime,
            a.LastModifyDatetime,
            a.Payments,
            a.Usages,
            a.IsMale,
            a.Epc,
            a.Membership
        }).ToList();

        dataGridViewAthletes.DataSource = athleteList;

        dataGridViewAthletes.Columns["Name"].HeaderText = "نام";
        dataGridViewAthletes.Columns["NationalCode"].HeaderText = "کد ملی";
        dataGridViewAthletes.Columns["Phone"].HeaderText = "تلفن";
        dataGridViewAthletes.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
        dataGridViewAthletes.Columns["MembershipString"].HeaderText = "نوع عضویت";
        dataGridViewAthletes.Columns["GenderString"].HeaderText = "جنسیت";
        dataGridViewAthletes.Columns["RemainingSessionCounts"].HeaderText = "جلسات باقی مانده";
        dataGridViewAthletes.Columns["Address"].HeaderText = "آدرس";
        dataGridViewAthletes.Columns["DateEndMembership"].HeaderText = "تاریخ پایان عضویت";
        dataGridViewAthletes.Columns["CurrentPlan"].HeaderText = "برنامه جاری";

        dataGridViewAthletes.Columns["Id"].Visible = false;
        dataGridViewAthletes.Columns["CreateDatetime"].Visible = false;
        dataGridViewAthletes.Columns["LastModifyDatetime"].Visible = false;
        dataGridViewAthletes.Columns["Payments"].Visible = false;
        dataGridViewAthletes.Columns["Usages"].Visible = false;
        dataGridViewAthletes.Columns["IsMale"].Visible = false;
        dataGridViewAthletes.Columns["Epc"].Visible = false;
        dataGridViewAthletes.Columns["Membership"].Visible = false;
    }

    private void DataGridViewAthletes_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridViewAthletes.SelectedRows.Count > 0)
        {
            int selectedId = (int)dataGridViewAthletes.SelectedRows[0].Cells["Id"].Value;
            _selectedAthlete = context.Athletes.Find(selectedId);
            if (_selectedAthlete != null)
            {
                textBoxName.Text = _selectedAthlete.Name;
                textBoxNationalCode.Text = _selectedAthlete.NationalCode;
                textBoxPhone.Text = _selectedAthlete.Phone;
                radioButtonMale.Checked = _selectedAthlete.IsMale;
                radioButtonFemale.Checked = !_selectedAthlete.IsMale;
                textBoxDateOfBirth.Text = _selectedAthlete.DateOfBirth;
                radioNormal.Checked = _selectedAthlete.Membership == MembershipType.Normal;
                radioMilitray.Checked = _selectedAthlete.Membership == MembershipType.Military;
                textBoxId.Text = _selectedAthlete.Id.ToString();
                textBoxAddress.Text = _selectedAthlete.Address;
                textBoxEpc.Text = _selectedAthlete.Epc;
                
                ShowAthletesPlanInfo(_selectedAthlete.Id);
            }
        }
    }

    private async void ButtonSignUp_Click(object sender, EventArgs e)
    {
        //if (await IsDuplicate())
        //{
        //    MessageBox.Show("اطلاعات تکراری است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //    return;
        //}
        int thisAthleteId ;

        if (string.IsNullOrEmpty(textBoxId.Text))
        {
            _selectedAthlete = new Athlete
            {
                Name = textBoxName.Text,
                NationalCode = textBoxNationalCode.Text,
                Phone = textBoxPhone.Text,
                IsMale = radioButtonMale.Checked,
                DateOfBirth = textBoxDateOfBirth.Text,
                CreateDatetime = DateTime.Now,
                LastModifyDatetime = DateTime.Now,
                Membership = radioNormal.Checked ? MembershipType.Normal : MembershipType.Military,
                Address = textBoxAddress.Text,
                Epc = textBoxEpc.Text
            };

            context.Athletes.Add(_selectedAthlete);

            await context.SaveChangesAsync();

            thisAthleteId = _selectedAthlete.Id;
        }
        else
        {
            _selectedAthlete.Name = textBoxName.Text;
            _selectedAthlete.NationalCode = textBoxNationalCode.Text;
            _selectedAthlete.Phone = textBoxPhone.Text;
            _selectedAthlete.IsMale = radioButtonMale.Checked;
            _selectedAthlete.DateOfBirth = textBoxDateOfBirth.Text;
            _selectedAthlete.LastModifyDatetime = DateTime.Now;
            _selectedAthlete.Membership = radioNormal.Checked ? MembershipType.Normal : MembershipType.Military;
            _selectedAthlete.Address = textBoxAddress.Text;
            _selectedAthlete.Epc = textBoxEpc.Text;

            context.Athletes.Update(_selectedAthlete);

            await context.SaveChangesAsync();

            thisAthleteId = _selectedAthlete.Id;
        }

        MessageBox.Show("اطلاعات ورزشکار ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        LoadAthletes();

        foreach (DataGridViewRow row in dataGridViewAthletes.Rows)
        {
            if (row.Cells["Id"].Value.ToString() == thisAthleteId.ToString())
            {
                row.Selected = true;

                return;
            }
        }

        ClearForm();
    }

    private void ClearForm()
    {
        textBoxName.Clear();
        textBoxNationalCode.Clear();
        textBoxPhone.Clear();
        radioButtonMale.Checked = true;
        textBoxDateOfBirth.Clear();
        _selectedAthlete = null;
        radioNormal.Checked = true;
        textBoxId.Text = string.Empty;
        textBoxAddress.Text = string.Empty;
        textBoxEpc.Text = string.Empty;
        // Clear plan information
        textBoxCurrentPlan.Clear();
        textBoxEndDate.Clear();
        textBoxRemainingSessions.Clear();
    }

    private void buttonNew_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        LoadAthletes();
    }

    private void buttonPayments_Click(object sender, EventArgs e)
    {
        FrmPaymentManagment frm = new(_selectedAthlete);

        frm.ShowDialog();
    }

    private void timerFocus_Tick(object sender, EventArgs e)
    {
        textBoxEpc.Focus();
    }

    private void buttonEpc_Click(object sender, EventArgs e)
    {
        if (!timerFocus.Enabled)
        {
            textBoxEpc.ReadOnly = false;

            timerFocus.Enabled = true;

            buttonEpc.Text = "توقف";

            textBoxEpc.Text = string.Empty;
        }
        else
        {
            textBoxEpc.ReadOnly = true;

            timerFocus.Enabled = false;

            buttonEpc.Text = "قرائت";
        }
    }

    private void textBoxEpc_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            buttonEpc_Click(sender, e);
        }
    }

    private async Task<bool> IsDuplicate()
        => await context.Athletes.AnyAsync(p => p.NationalCode.Contains(textBoxNationalCode.Text)
                                        || p.Epc == textBoxEpc.Text);

    private async void buttonDelete_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxId.Text))
        {
            return;
        }

        if (MessageBox.Show("از حذف ورزشکار مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,MessageBoxIcon.Question)
            == DialogResult.No)
        {
            return;
        }

        try
        {
            await context.Athletes
               .Where(p => p.Id == int.Parse(textBoxId.Text))
               .ExecuteDeleteAsync();

            LoadAthletes();
        }
        catch (Exception)
        {
            MessageBox.Show("امکان حذف ورزشکار وجود ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void ShowAthletesPlanInfo(int athleteId)
    {
        var latestPayment = context.Payments
            .Include(p => p.Plan)
            .Where(p => p.AthleteId == athleteId)
            .OrderByDescending(p => p.CreateDatetime)
            .FirstOrDefault();

        string planInfo = "";
        if (latestPayment?.Plan != null)
        {
            textBoxCurrentPlan.Text = $"{latestPayment.Plan.Title}";
        }
        else
        {
            textBoxCurrentPlan.Text = "";
        }

        textBoxEndDate.Text = _selectedAthlete.DateEndMembership ?? "نامشخص";
        textBoxRemainingSessions.Text = _selectedAthlete.RemainingSessionCounts.ToString();
    }
}