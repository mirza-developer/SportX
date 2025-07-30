using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Data;

namespace SportX.Ui.Pages;
public partial class FrmPaymentMonthlyReport : Form
{
    private SportXContext context = new();
    private Athlete selectedAthlete;

    public FrmPaymentMonthlyReport()
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
        int indexer = 1;

        var payments = context.Payments
            .Include(p => p.Athlete)
            .Include(p => p.Plan)
            .AsQueryable();

        // Filter by selected athlete (optional)
        if (selectedAthlete != null)
        {
            payments = payments.Where(p => p.AthleteId == selectedAthlete.Id);
        }

        payments = payments.OrderBy(p => p.PayDate);

        var paymentsList = payments.ToList();

        if (!string.IsNullOrEmpty(dateTimePickerFromDate.Text))
        {
            paymentsList = paymentsList.Where(p => PersianCalendarTools.PersianToGregorian(p.PayDate).Date >= PersianCalendarTools.PersianToGregorian(dateTimePickerFromDate.Text)).ToList();
        }

        if (!string.IsNullOrEmpty(dateTimePickerToDate.Text))
        {
            paymentsList = paymentsList.Where(p => PersianCalendarTools.PersianToGregorian(p.PayDate).Date <= PersianCalendarTools.PersianToGregorian(dateTimePickerToDate.Text)).ToList();
        }

        dataGridViewReport.DataSource = paymentsList.Select(p => new
        {
            ردیف = indexer++,
            p.PriceInTomans,
            p.PayDate,
            AthleteName = p.Athlete.Name,
            PlanTitle = p.Plan?.Title ?? "بدون پلن",
            p.Description,
            p.ReceiptNumber,
            p.SessionCountFor,
            p.DateEndMembership,
            PaymentType = p.PaymentTypeString
        }).ToList();

        // Set DataGridView column headers in Persian
        dataGridViewReport.Columns["PriceInTomans"].HeaderText = "مبلغ (تومان)";
        dataGridViewReport.Columns["PayDate"].HeaderText = "تاریخ پرداخت";
        dataGridViewReport.Columns["AthleteName"].HeaderText = "ورزشکار";
        dataGridViewReport.Columns["PlanTitle"].HeaderText = "پلن";
        dataGridViewReport.Columns["Description"].HeaderText = "توضیحات";
        dataGridViewReport.Columns["ReceiptNumber"].HeaderText = "شماره رسید";
        dataGridViewReport.Columns["SessionCountFor"].HeaderText = "تعداد جلسات";
        dataGridViewReport.Columns["DateEndMembership"].HeaderText = "تاریخ پایان عضویت";
        dataGridViewReport.Columns["PaymentType"].HeaderText = "نوع پرداخت";

        // Calculate the total sum of payments
        var totalPayments = paymentsList.Sum(p => p.PriceInTomans);
        labelTotalPayments.Text = $"جمع مبالغ پرداختی: {totalPayments} تومان";
    }

    private void FrmPaymentMonthlyReport_Load(object sender, EventArgs e)
    {
        dateTimePickerFromDate.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now);

        dateTimePickerToDate.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now);
    }
}
