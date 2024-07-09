using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Data;

namespace SportX.Ui.Pages;
public partial class FrmPaymentManagment : Form
{
    private SportXContext _context = new(new DbContextOptions<SportXContext>());
    private Athlete selectedAthlete;
    public FrmPaymentManagment()
    {
        InitializeComponent();

        ClearForm();
    }

    private void ButtonSelectAthlete_Click(object sender, EventArgs e)
    {
        using var selectAthleteForm = new FrmChooseAthlete();

        if (selectAthleteForm.ShowDialog() == DialogResult.OK)
        {
            selectedAthlete = selectAthleteForm.SelectedAthlete;
            buttonSelectAthlete.Text = $"انتخاب شده: {selectedAthlete.Name}";
            LoadPaymentHistory();
        }
    }

    private void LoadPaymentHistory()
    {
        if (selectedAthlete is not null)
        {
            var payments = _context.Payments
                .Where(p => p.AthleteId == selectedAthlete.Id)
                .OrderByDescending(p => p.PayDate)
                .Select(p => new
                {
                    p.PriceInTomans,
                    p.PayDate,
                    p.Description,
                    p.ReceiptNumber,
                    PaymentType = p.PaymentType.ToString(),
                    p.SessionCountFor
                })
                .ToList();

            dataGridViewPayments.DataSource = payments;

            dataGridViewPayments.Columns["PriceInTomans"].HeaderText = "مبلغ (تومان)";
            dataGridViewPayments.Columns["PayDate"].HeaderText = "تاریخ پرداخت";
            dataGridViewPayments.Columns["Description"].HeaderText = "توضیحات";
            dataGridViewPayments.Columns["ReceiptNumber"].HeaderText = "شماره رسید";
            dataGridViewPayments.Columns["PaymentType"].HeaderText = "نوع پرداخت";
            dataGridViewPayments.Columns["SessionCountFor"].HeaderText = "تعداد جلسات";

            var totalPayments = payments.Sum(p => p.PriceInTomans);
            labelTotalPayments.Text = $"جمع مبالغ پرداختی: {totalPayments} تومان";
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (selectedAthlete == null || string.IsNullOrWhiteSpace(textBoxPrice.Text) || string.IsNullOrWhiteSpace(textBoxPayDate.Text) || string.IsNullOrWhiteSpace(textBoxSessionCount.Text))
        {
            MessageBox.Show("لطفا تمام فیلدها را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var newPayment = new Payment
        {
            AthleteId = selectedAthlete.Id,
            PriceInTomans = long.Parse(textBoxPrice.Text),
            PayDate = textBoxPayDate.Text,
            Description = textBoxDescription.Text,
            ReceiptNumber = textBoxReceiptNumber.Text,
            SessionCountFor = int.Parse(textBoxSessionCount.Text),
            PaymentType = (PaymentType)comboBoxPaymentType.SelectedIndex,
            CreateDatetime = DateTime.Now,
            DateEndMembership = txtboxPaymentDateEnd.Text
        };

        _context.Payments.Add(newPayment);

        selectedAthlete.RemainingSessionCounts += newPayment.SessionCountFor;

        selectedAthlete.DateEndMembership = txtboxPaymentDateEnd.Text;

        _context.Update(selectedAthlete);

        _context.SaveChanges();

        MessageBox.Show("پرداخت ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);

        LoadPaymentHistory();
    }

    private void ClearForm()
    {
        textBoxPrice.Clear();
        textBoxPayDate.Clear();
        textBoxDescription.Clear();
        textBoxReceiptNumber.Clear();
        textBoxSessionCount.Clear();
        comboBoxPaymentType.SelectedIndex = -1;
        selectedAthlete = null;
        buttonSelectAthlete.Text = "انتخاب ورزشکار";
        textBoxPayDate.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now);
        txtboxPaymentDateEnd.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now.AddMonths(1));
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
    }
}
