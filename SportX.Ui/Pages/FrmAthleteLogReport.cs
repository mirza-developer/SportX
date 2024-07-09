using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Data;
using System.Globalization;

namespace SportX.Ui.Pages;
public partial class FrmAthleteLogReport : Form
{
    private SportXContext context = new();
    private Athlete selectedAthlete;

    public FrmAthleteLogReport()
    {
        InitializeComponent();
    }

    private void ButtonChooseAthlete_Click(object sender, EventArgs e)
    {
        using (FrmChooseAthlete frmChooseAthlete = new FrmChooseAthlete())
        {
            if (frmChooseAthlete.ShowDialog() == DialogResult.OK)
            {
                selectedAthlete = frmChooseAthlete.SelectedAthlete;
                textBoxAthlete.Text = selectedAthlete.Name;
            }
        }
    }

    private void ButtonGenerateReport_Click(object sender, EventArgs e)
    {
        if (selectedAthlete == null)
        {
            MessageBox.Show("لطفا ورزشکار را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var persianCalendar = new PersianCalendar();
        DateTime fromDate = DateTime.ParseExact(dateTimePickerFromDate.Text, "yyyy/MM/dd", null);
        DateTime toDate = DateTime.ParseExact(dateTimePickerToDate.Text, "yyyy/MM/dd", null);

        var usageLogs = context.Usages
            .Where(u => u.AthleteId == selectedAthlete.Id &&
                        u.CreateDatetime >= fromDate &&
                        u.CreateDatetime <= toDate)
            .Select(u => new
            {
                u.IsEntered,
                u.IsPaid,
                u.CreateDatetime
            })
            .ToList();

        dataGridViewReport.DataSource = usageLogs;

        dataGridViewReport.Columns["IsEntered"].HeaderText = "ورود";
        dataGridViewReport.Columns["IsPaid"].HeaderText = "پرداخت شده";
        dataGridViewReport.Columns["CreateDatetime"].HeaderText = "تاریخ ورود/خروج";

        var totalUsageCount = usageLogs.Count;
        labelTotalUsageCount.Text = $"تعداد کل ورود و خروج: {totalUsageCount}";
    }
}
