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
            buttonGenerateReport = new Button();
            dataGridViewReport = new DataGridView();
            labelTotalPayments = new Label();
            dateTimePickerToDate = new TextBox();
            dateTimePickerFromDate = new TextBox();
            labelFromDate = new Label();
            labelToDate = new Label();
            buttonChooseAthlete = new Button();
            textBoxAthlete = new TextBox();
            labelAthlete = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(530, 113);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(156, 30);
            buttonGenerateReport.TabIndex = 4;
            buttonGenerateReport.Text = "تولید گزارش";
            buttonGenerateReport.Click += ButtonGenerateReport_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewReport.Location = new Point(20, 150);
            dataGridViewReport.MultiSelect = false;
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersVisible = false;
            dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReport.Size = new Size(760, 368);
            dataGridViewReport.TabIndex = 5;
            // 
            // labelTotalPayments
            // 
            labelTotalPayments.Location = new Point(20, 521);
            labelTotalPayments.Name = "labelTotalPayments";
            labelTotalPayments.Size = new Size(760, 20);
            labelTotalPayments.TabIndex = 6;
            labelTotalPayments.Text = "جمع مبالغ پرداختی: 0 تومان";
            labelTotalPayments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.Location = new Point(530, 53);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(154, 23);
            dateTimePickerToDate.TabIndex = 15;
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.Location = new Point(530, 23);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(154, 23);
            dateTimePickerFromDate.TabIndex = 14;
            // 
            // labelFromDate
            // 
            labelFromDate.Location = new Point(714, 23);
            labelFromDate.Name = "labelFromDate";
            labelFromDate.Size = new Size(50, 20);
            labelFromDate.TabIndex = 12;
            labelFromDate.Text = "از تاریخ";
            labelFromDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelToDate
            // 
            labelToDate.Location = new Point(714, 53);
            labelToDate.Name = "labelToDate";
            labelToDate.Size = new Size(50, 20);
            labelToDate.TabIndex = 13;
            labelToDate.Text = "تا تاریخ";
            labelToDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonChooseAthlete
            // 
            buttonChooseAthlete.Location = new Point(370, 83);
            buttonChooseAthlete.Name = "buttonChooseAthlete";
            buttonChooseAthlete.Size = new Size(154, 23);
            buttonChooseAthlete.TabIndex = 17;
            buttonChooseAthlete.Text = "انتخاب ورزشکار";
            buttonChooseAthlete.Click += ButtonChooseAthlete_Click;
            // 
            // textBoxAthlete
            // 
            textBoxAthlete.Location = new Point(530, 83);
            textBoxAthlete.Name = "textBoxAthlete";
            textBoxAthlete.ReadOnly = true;
            textBoxAthlete.Size = new Size(154, 23);
            textBoxAthlete.TabIndex = 16;
            // 
            // labelAthlete
            // 
            labelAthlete.Location = new Point(714, 83);
            labelAthlete.Name = "labelAthlete";
            labelAthlete.Size = new Size(50, 20);
            labelAthlete.TabIndex = 18;
            labelAthlete.Text = "ورزشکار";
            labelAthlete.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmPaymentMonthlyReport
            // 
            ClientSize = new Size(800, 548);
            Controls.Add(labelAthlete);
            Controls.Add(buttonChooseAthlete);
            Controls.Add(textBoxAthlete);
            Controls.Add(dateTimePickerToDate);
            Controls.Add(dateTimePickerFromDate);
            Controls.Add(labelFromDate);
            Controls.Add(labelToDate);
            Controls.Add(buttonGenerateReport);
            Controls.Add(dataGridViewReport);
            Controls.Add(labelTotalPayments);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPaymentMonthlyReport";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "گزارش پرداخت‌ها";
            Load += FrmPaymentMonthlyReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonGenerateReport;
        private DataGridView dataGridViewReport;
        private Label labelTotalPayments;
        private TextBox dateTimePickerToDate;
        private TextBox dateTimePickerFromDate;
        private Label labelFromDate;
        private Label labelToDate;
        private Button buttonChooseAthlete;
        private TextBox textBoxAthlete;
        private Label labelAthlete;
        #endregion
    }
}