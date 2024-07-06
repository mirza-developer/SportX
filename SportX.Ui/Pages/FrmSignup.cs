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
        var athletes = context.Athletes.ToList();
        dataGridViewAthletes.DataSource = athletes;

        // Set Persian column headers
        dataGridViewAthletes.Columns["Name"].HeaderText = "نام";
        dataGridViewAthletes.Columns["NationalCode"].HeaderText = "کد ملی";
        dataGridViewAthletes.Columns["Phone"].HeaderText = "تلفن";
        dataGridViewAthletes.Columns["DateOfBirth"].HeaderText = "تاریخ تولد";
        dataGridViewAthletes.Columns["PaidUntilDate"].HeaderText = "تاریخ اعتبار";
        dataGridViewAthletes.Columns["MembershipString"].HeaderText = "نوع عضویت";
        dataGridViewAthletes.Columns["GenderString"].HeaderText = "جنسیت";

        dataGridViewAthletes.Columns["Id"].Visible = false;
        dataGridViewAthletes.Columns["CreateDatetime"].Visible = false;
        dataGridViewAthletes.Columns["LastModifyDatetime"].Visible = false;
        dataGridViewAthletes.Columns["Payments"].Visible = false;
        dataGridViewAthletes.Columns["Usages"].Visible = false;
        dataGridViewAthletes.Columns["IsMale"].Visible = false;
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
            }
        }
    }

    private void ButtonSignUp_Click(object sender, EventArgs e)
    {
        if (_selectedAthlete == null)
        {
            // Create new athlete
            Athlete newAthlete = new Athlete
            {
                Name = textBoxName.Text,
                NationalCode = textBoxNationalCode.Text,
                Phone = textBoxPhone.Text,
                IsMale = radioButtonMale.Checked,
                DateOfBirth = textBoxDateOfBirth.Text,
                CreateDatetime = DateTime.Now,
                Membership = radioNormal.Checked ? MembershipType.Normal : MembershipType.Military
            };

            context.Athletes.Add(newAthlete);
        }
        else
        {
            // Update existing athlete
            _selectedAthlete.Name = textBoxName.Text;
            _selectedAthlete.NationalCode = textBoxNationalCode.Text;
            _selectedAthlete.Phone = textBoxPhone.Text;
            _selectedAthlete.IsMale = radioButtonMale.Checked;
            _selectedAthlete.DateOfBirth = textBoxDateOfBirth.Text;
            _selectedAthlete.LastModifyDatetime = DateTime.Now;
            _selectedAthlete.Membership = radioNormal.Checked ? MembershipType.Normal : MembershipType.Military;
        }

        context.SaveChanges();
        MessageBox.Show("اطلاعات ورزشکار ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadAthletes(); // Refresh the DataGridView
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
    }

    private void buttonNew_Click(object sender, EventArgs e)
    {
        ClearForm();
    }
}
