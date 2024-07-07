using Microsoft.EntityFrameworkCore;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Data;

namespace SportX.Ui.Pages;
public partial class FrmChooseAthlete : Form
{
    private SportXContext _context = new(new DbContextOptions<SportXContext>());
    public Athlete SelectedAthlete { get; private set; }
  
    public FrmChooseAthlete()
    {
        InitializeComponent();

        LoadAthletes();
    }

    private void LoadAthletes()
    {
        var athletes = _context.Athletes
            .Select(a => new
            {
                a.Id,
                a.Name,
                a.NationalCode,
                Gender = a.IsMale ? "مرد" : "زن",
                Membership = a.Membership == MembershipType.Normal ? "معمولی" : "نظامی"
            })
            .ToList();

        dataGridViewAthletes.DataSource = athletes;

        dataGridViewAthletes.Columns["Id"].HeaderText = "شناسه";
        dataGridViewAthletes.Columns["Name"].HeaderText = "نام";
        dataGridViewAthletes.Columns["NationalCode"].HeaderText = "کد ملی";
        dataGridViewAthletes.Columns["Gender"].HeaderText = "جنسیت";
        dataGridViewAthletes.Columns["Membership"].HeaderText = "نوع عضویت";
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
        var query = _context.Athletes.AsQueryable();

        if (!string.IsNullOrWhiteSpace(textBoxAthleteId.Text))
        {
            if (int.TryParse(textBoxAthleteId.Text, out int athleteId))
            {
                query = query.Where(a => a.Id == athleteId);
            }
        }

        if (!string.IsNullOrWhiteSpace(textBoxNationalCode.Text))
        {
            query = query.Where(a => a.NationalCode.Contains(textBoxNationalCode.Text));
        }

        if (!string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            query = query.Where(a => a.Name.Contains(textBoxName.Text));
        }

        var athletes = query.Select(a => new
        {
            a.Id,
            a.Name,
            a.NationalCode,
            Gender = a.IsMale ? "مرد" : "زن",
            Membership = a.Membership == MembershipType.Normal ? "معمولی" : "نظامی"
        })
        .ToList();

        dataGridViewAthletes.DataSource = athletes;
    }

    private async void ButtonSelect_Click(object sender, EventArgs e)
    {
        if (dataGridViewAthletes.SelectedRows.Count > 0)
        {
            var selectedId = (int)dataGridViewAthletes.SelectedRows[0].Cells["Id"].Value;
            SelectedAthlete = await _context.Athletes.FindAsync(selectedId);
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("لطفاً یک ورزشکار را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
