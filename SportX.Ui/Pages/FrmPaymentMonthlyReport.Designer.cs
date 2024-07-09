namespace SportX.Ui.Pages
{
    partial class FrmPaymentMonthlyReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelYear = new Label();
            this.comboBoxYear = new ComboBox();
            this.labelMonth = new Label();
            this.comboBoxMonth = new ComboBox();
            this.buttonGenerateReport = new Button();
            this.dataGridViewReport = new DataGridView();
            this.labelTotalPayments = new Label();

            this.SuspendLayout();

            // labelYear
            this.labelYear.Text = "سال";
            this.labelYear.Location = new System.Drawing.Point(300, 20);
            this.labelYear.Size = new System.Drawing.Size(50, 20);
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // comboBoxYear
            this.comboBoxYear.Location = new System.Drawing.Point(150, 20);
            this.comboBoxYear.Size = new System.Drawing.Size(120, 20);
            for (int i = 1400; i <= 1450; i++)
            {
                this.comboBoxYear.Items.Add(i.ToString());
            }

            // labelMonth
            this.labelMonth.Text = "ماه";
            this.labelMonth.Location = new System.Drawing.Point(300, 50);
            this.labelMonth.Size = new System.Drawing.Size(50, 20);
            this.labelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // comboBoxMonth
            this.comboBoxMonth.Location = new System.Drawing.Point(150, 50);
            this.comboBoxMonth.Size = new System.Drawing.Size(120, 20);
            for (int i = 1; i <= 12; i++)
            {
                this.comboBoxMonth.Items.Add(i.ToString());
            }

            // buttonGenerateReport
            this.buttonGenerateReport.Text = "تولید گزارش";
            this.buttonGenerateReport.Location = new System.Drawing.Point(150, 80);
            this.buttonGenerateReport.Size = new System.Drawing.Size(120, 30);
            this.buttonGenerateReport.Click += new EventHandler(this.ButtonGenerateReport_Click);

            // dataGridViewReport
            this.dataGridViewReport.Location = new System.Drawing.Point(20, 120);
            this.dataGridViewReport.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.MultiSelect = false;

            // labelTotalPayments
            this.labelTotalPayments.Text = "جمع مبالغ پرداختی: 0 تومان";
            this.labelTotalPayments.Location = new System.Drawing.Point(20, 430);
            this.labelTotalPayments.Size = new System.Drawing.Size(760, 20);
            this.labelTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // MonthlyReportForm
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.labelTotalPayments);
            this.Name = "MonthlyReportForm";
            this.Text = "گزارش ماهانه پرداخت‌ها";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label labelYear;
        private ComboBox comboBoxYear;
        private Label labelMonth;
        private ComboBox comboBoxMonth;
        private Button buttonGenerateReport;
        private DataGridView dataGridViewReport;
        private Label labelTotalPayments;
        #endregion
    }
}