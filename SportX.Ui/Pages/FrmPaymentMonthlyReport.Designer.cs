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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentMonthlyReport));
            labelYear = new Label();
            comboBoxYear = new ComboBox();
            labelMonth = new Label();
            comboBoxMonth = new ComboBox();
            buttonGenerateReport = new Button();
            dataGridViewReport = new DataGridView();
            labelTotalPayments = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // labelYear
            // 
            labelYear.Location = new Point(716, 23);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(50, 20);
            labelYear.TabIndex = 0;
            labelYear.Text = "سال";
            labelYear.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxYear
            // 
            comboBoxYear.Items.AddRange(new object[] { "1403", "1404", "1405", "1406", "1407" });
            comboBoxYear.Location = new Point(530, 23);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(156, 23);
            comboBoxYear.TabIndex = 1;
            // 
            // labelMonth
            // 
            labelMonth.Location = new Point(716, 53);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(50, 20);
            labelMonth.TabIndex = 2;
            labelMonth.Text = "ماه";
            labelMonth.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxMonth.Location = new Point(530, 53);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(156, 23);
            comboBoxMonth.TabIndex = 3;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(530, 83);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(156, 30);
            buttonGenerateReport.TabIndex = 4;
            buttonGenerateReport.Text = "تولید گزارش";
            buttonGenerateReport.Click += ButtonGenerateReport_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.Location = new Point(20, 120);
            dataGridViewReport.MultiSelect = false;
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersVisible = false;
            dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReport.Size = new Size(760, 368);
            dataGridViewReport.TabIndex = 5;
            // 
            // labelTotalPayments
            // 
            labelTotalPayments.Location = new Point(20, 491);
            labelTotalPayments.Name = "labelTotalPayments";
            labelTotalPayments.Size = new Size(760, 20);
            labelTotalPayments.TabIndex = 6;
            labelTotalPayments.Text = "جمع مبالغ پرداختی: 0 تومان";
            labelTotalPayments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmPaymentMonthlyReport
            // 
            ClientSize = new Size(800, 518);
            Controls.Add(labelYear);
            Controls.Add(comboBoxYear);
            Controls.Add(labelMonth);
            Controls.Add(comboBoxMonth);
            Controls.Add(buttonGenerateReport);
            Controls.Add(dataGridViewReport);
            Controls.Add(labelTotalPayments);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPaymentMonthlyReport";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "گزارش ماهانه پرداخت‌ها";
            Load += FrmPaymentMonthlyReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
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