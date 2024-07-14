using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Data;

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
        using FrmChooseAthlete frmChooseAthlete = new();

        if (frmChooseAthlete.ShowDialog() == DialogResult.OK)
        {
            selectedAthlete = frmChooseAthlete.SelectedAthlete;
            textBoxAthlete.Text = selectedAthlete.Name;
        }
    }

    private void ButtonGenerateReport_Click(object sender, EventArgs e)
    {
        if (selectedAthlete == null)
        {
            MessageBox.Show("لطفا ورزشکار را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var usageLogs = context.Usages
                                                     .Include(p => p.Athlete)
                                                     .AsQueryable()
                                                     .Where(u => u.AthleteId == selectedAthlete.Id);

        if (!string.IsNullOrEmpty(dateTimePickerFromDate.Text))
        {
            DateTime fromDate = PersianCalendarTools.PersianToGregorian(dateTimePickerFromDate.Text);

            usageLogs = usageLogs.Where(u => u.CreateDatetime >= fromDate);
        }

        if (!string.IsNullOrEmpty(dateTimePickerToDate.Text))
        {
            DateTime toDate = PersianCalendarTools.PersianToGregorian(dateTimePickerToDate.Text);

            usageLogs = usageLogs.Where(u => u.CreateDatetime <= toDate);
        }

        int index = 0;

        dataGridViewReport.DataSource = usageLogs.ToList()
            .Select(u => new
            {
                Index = index++,
                Name = u.Athlete.Name,
                CreateDate = PersianCalendarTools.GregorianToPersian(u.CreateDatetime),
                CreateTime = u.CreateDatetime.ToString("HH:mm")
            })
            .ToList();

        dataGridViewReport.Columns["Index"].HeaderText = "ردیف";
        dataGridViewReport.Columns["Name"].HeaderText = "نام ورزشکار";
        dataGridViewReport.Columns["CreateTime"].HeaderText = "ساعت";
        dataGridViewReport.Columns["CreateDate"].HeaderText = "تاریخ";

        var totalUsageCount = usageLogs.Count();
        labelTotalUsageCount.Text = $"تعداد کل ورود و خروج: {totalUsageCount}";
    }
}
