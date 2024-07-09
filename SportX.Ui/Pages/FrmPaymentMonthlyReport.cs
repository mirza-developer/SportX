using Microsoft.EntityFrameworkCore;
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
        DateTime firstDayOfMonth = persianCalendar.ToDateTime(year, month, 1, 0, 0, 0, 0);
        DateTime lastDayOfMonth = persianCalendar.AddMonths(firstDayOfMonth, 1).AddDays(-1);

        var payments = context.Payments
            .Where(p => DateTime.ParseExact(p.PayDate, "yyyy/MM/dd", null) >= firstDayOfMonth &&
                        DateTime.ParseExact(p.PayDate, "yyyy/MM/dd", null) <= lastDayOfMonth)
            .Select(p => new
            {
                p.PriceInTomans,
                p.PayDate,
                p.Description,
                p.ReceiptNumber,
                p.SessionCountFor,
                p.DateEndMembership,
                PaymentType = p.PaymentType.ToString()
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

        // Calculate the total sum of payments
        var totalPayments = payments.Sum(p => p.PriceInTomans);
        labelTotalPayments.Text = $"جمع مبالغ پرداختی: {totalPayments} تومان";
    }
}
