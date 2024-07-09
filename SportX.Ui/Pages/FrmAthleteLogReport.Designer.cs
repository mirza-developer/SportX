namespace SportX.Ui.Pages
{
    partial class FrmAthleteLogReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAthleteLogReport));
            labelAthlete = new Label();
            textBoxAthlete = new TextBox();
            buttonChooseAthlete = new Button();
            labelFromDate = new Label();
            dateTimePickerFromDate = new DateTimePicker();
            labelToDate = new Label();
            dateTimePickerToDate = new DateTimePicker();
            buttonGenerateReport = new Button();
            dataGridViewReport = new DataGridView();
            labelTotalUsageCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // labelAthlete
            // 
            labelAthlete.Location = new Point(300, 20);
            labelAthlete.Name = "labelAthlete";
            labelAthlete.Size = new Size(100, 20);
            labelAthlete.TabIndex = 0;
            labelAthlete.Text = "انتخاب ورزشکار";
            labelAthlete.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxAthlete
            // 
            textBoxAthlete.Location = new Point(150, 20);
            textBoxAthlete.Name = "textBoxAthlete";
            textBoxAthlete.ReadOnly = true;
            textBoxAthlete.Size = new Size(120, 23);
            textBoxAthlete.TabIndex = 1;
            // 
            // buttonChooseAthlete
            // 
            buttonChooseAthlete.Location = new Point(50, 20);
            buttonChooseAthlete.Name = "buttonChooseAthlete";
            buttonChooseAthlete.Size = new Size(80, 25);
            buttonChooseAthlete.TabIndex = 2;
            buttonChooseAthlete.Text = "انتخاب";
            buttonChooseAthlete.Click += ButtonChooseAthlete_Click;
            // 
            // labelFromDate
            // 
            labelFromDate.Location = new Point(300, 50);
            labelFromDate.Name = "labelFromDate";
            labelFromDate.Size = new Size(50, 20);
            labelFromDate.TabIndex = 3;
            labelFromDate.Text = "از تاریخ";
            labelFromDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.CustomFormat = "yyyy/MM/dd";
            dateTimePickerFromDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerFromDate.Location = new Point(150, 50);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(120, 23);
            dateTimePickerFromDate.TabIndex = 4;
            // 
            // labelToDate
            // 
            labelToDate.Location = new Point(300, 80);
            labelToDate.Name = "labelToDate";
            labelToDate.Size = new Size(50, 20);
            labelToDate.TabIndex = 5;
            labelToDate.Text = "تا تاریخ";
            labelToDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.CustomFormat = "yyyy/MM/dd";
            dateTimePickerToDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerToDate.Location = new Point(150, 80);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(120, 23);
            dateTimePickerToDate.TabIndex = 6;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(150, 110);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(120, 30);
            buttonGenerateReport.TabIndex = 7;
            buttonGenerateReport.Text = "تولید گزارش";
            buttonGenerateReport.Click += ButtonGenerateReport_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.Location = new Point(20, 150);
            dataGridViewReport.MultiSelect = false;
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReport.Size = new Size(760, 300);
            dataGridViewReport.TabIndex = 8;
            // 
            // labelTotalUsageCount
            // 
            labelTotalUsageCount.Location = new Point(20, 460);
            labelTotalUsageCount.Name = "labelTotalUsageCount";
            labelTotalUsageCount.Size = new Size(760, 20);
            labelTotalUsageCount.TabIndex = 9;
            labelTotalUsageCount.Text = "تعداد کل ورود و خروج: 0";
            labelTotalUsageCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmAthleteLogReport
            // 
            ClientSize = new Size(800, 490);
            Controls.Add(labelAthlete);
            Controls.Add(textBoxAthlete);
            Controls.Add(buttonChooseAthlete);
            Controls.Add(labelFromDate);
            Controls.Add(dateTimePickerFromDate);
            Controls.Add(labelToDate);
            Controls.Add(dateTimePickerToDate);
            Controls.Add(buttonGenerateReport);
            Controls.Add(dataGridViewReport);
            Controls.Add(labelTotalUsageCount);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAthleteLogReport";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "گزارش ورود و خروج ورزشکار";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelAthlete;
        private TextBox textBoxAthlete;
        private Button buttonChooseAthlete;
        private Label labelFromDate;
        private DateTimePicker dateTimePickerFromDate;
        private Label labelToDate;
        private DateTimePicker dateTimePickerToDate;
        private Button buttonGenerateReport;
        private DataGridView dataGridViewReport;
        private Label labelTotalUsageCount;
        #endregion
    }
}