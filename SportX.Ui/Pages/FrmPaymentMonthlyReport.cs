using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Services;
using System.Data;

namespace SportX.Ui.Pages;
public partial class FrmPaymentMonthlyReport : Form
{
    private SportXContext context = new();
    public FrmPaymentMonthlyReport()
    {
        InitializeComponent();
    }

    private void ButtonGenerateReport_Click(object sender, EventArgs e)
    {
        int indexer = 1;

        var payments = context.Payments
            .Include(p => p.Athlete)
            .OrderBy(p => p.PayDate)
            .ToList();

        if (!string.IsNullOrEmpty(dateTimePickerFromDate.Text))
        {
            payments = payments.Where(p => PersianCalendarTools.PersianToGregorian(p.PayDate).Date >= PersianCalendarTools.PersianToGregorian(dateTimePickerFromDate.Text)).ToList();
        }

        if (!string.IsNullOrEmpty(dateTimePickerToDate.Text))
        {
            payments = payments.Where(p => PersianCalendarTools.PersianToGregorian(p.PayDate).Date <= PersianCalendarTools.PersianToGregorian(dateTimePickerToDate.Text)).ToList();
        }

        dataGridViewReport.DataSource = payments.Select(p => new
        {
            ردیف = indexer++,
            p.PriceInTomans,
            p.PayDate,
            AthleteName = p.Athlete.Name,
            p.Description,
            p.ReceiptNumber,
            p.SessionCountFor,
            p.DateEndMembership,
            PaymentType = p.PaymentTypeString
        }).ToList();

        // Set DataGridView column headers in Persian
        dataGridViewReport.Columns["PriceInTomans"].HeaderText = "مبلغ (تومان)";
        dataGridViewReport.Columns["PayDate"].HeaderText = "تاریخ پرداخت";
        dataGridViewReport.Columns["Description"].HeaderText = "توضیحات";
        dataGridViewReport.Columns["ReceiptNumber"].HeaderText = "شماره رسید";
        dataGridViewReport.Columns["SessionCountFor"].HeaderText = "تعداد جلسات";
        dataGridViewReport.Columns["DateEndMembership"].HeaderText = "تاریخ پایان عضویت";
        dataGridViewReport.Columns["PaymentType"].HeaderText = "نوع پرداخت";
        dataGridViewReport.Columns["AthleteName"].HeaderText = "ورزشکار";

        // Calculate the total sum of payments
        var totalPayments = payments.Sum(p => p.PriceInTomans);
        labelTotalPayments.Text = $"جمع مبالغ پرداختی: {totalPayments} تومان";
    }

    private void FrmPaymentMonthlyReport_Load(object sender, EventArgs e)
    {
        dateTimePickerFromDate.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now);

        dateTimePickerToDate.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now);
    }
}
