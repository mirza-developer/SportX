using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;

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
        if (comboBoxYear.SelectedItem == null || comboBoxMonth.SelectedItem == null)
        {
            MessageBox.Show("لطفا سال و ماه را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int year = int.Parse(comboBoxYear.SelectedItem.ToString());
        int month = int.Parse(comboBoxMonth.SelectedItem.ToString());

        var persianCalendar = new PersianCalendar();
        var monthStartDate = persianCalendar.ToDateTime(year, month, 1, 0, 0, 0, 0);
        var monthEndDate = monthStartDate.AddMonths(1).AddDays(-1);

        string firstDayOfMonth = PersianCalendarTools.GregorianToPersian(monthStartDate);
        string lastDayOfMonth = PersianCalendarTools.GregorianToPersian(monthEndDate);

        int indexer = 1;

        var payments = context.Payments
            .Include(p=> p.Athlete)
            .ToList()
            .OrderBy(p => p.PayDate)
            .Where(p => PersianCalendarTools.PersianToGregorian(p.PayDate).Date >= monthStartDate
                        && PersianCalendarTools.PersianToGregorian(p.PayDate).Date <= monthEndDate)
            .Select(p => new
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
            })
            .ToList();

        dataGridViewReport.DataSource = payments;

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
        var persianCalendar = new PersianCalendar();

        comboBoxMonth.SelectedItem = persianCalendar.GetMonth(DateTime.Now).ToString();

        comboBoxYear.SelectedItem = persianCalendar.GetYear(DateTime.Now).ToString();
    }
}
