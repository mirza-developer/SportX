namespace SportX.Ui.Pages
{
    partial class FrmPaymentManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentManagment));
            buttonSelectAthlete = new Button();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelPayDate = new Label();
            textBoxPayDate = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelReceiptNumber = new Label();
            textBoxReceiptNumber = new TextBox();
            labelPaymentType = new Label();
            comboBoxPaymentType = new ComboBox();
            labelSessionCount = new Label();
            textBoxSessionCount = new TextBox();
            buttonSave = new Button();
            dataGridViewPayments = new DataGridView();
            btnClear = new Button();
            labelTotalPayments = new Label();
            label1 = new Label();
            txtboxPaymentDateEnd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // buttonSelectAthlete
            // 
            buttonSelectAthlete.Location = new Point(62, 20);
            buttonSelectAthlete.Name = "buttonSelectAthlete";
            buttonSelectAthlete.Size = new Size(303, 34);
            buttonSelectAthlete.TabIndex = 0;
            buttonSelectAthlete.Text = "انتخاب ورزشکار";
            buttonSelectAthlete.Click += ButtonSelectAthlete_Click;
            // 
            // labelPrice
            // 
            labelPrice.Location = new Point(300, 60);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(100, 20);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "مبلغ (تومان)";
            labelPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(100, 60);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(200, 31);
            textBoxPrice.TabIndex = 2;
            // 
            // labelPayDate
            // 
            labelPayDate.Location = new Point(300, 90);
            labelPayDate.Name = "labelPayDate";
            labelPayDate.Size = new Size(100, 20);
            labelPayDate.TabIndex = 3;
            labelPayDate.Text = "تاریخ پرداخت";
            labelPayDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxPayDate
            // 
            textBoxPayDate.Location = new Point(100, 90);
            textBoxPayDate.Name = "textBoxPayDate";
            textBoxPayDate.Size = new Size(200, 31);
            textBoxPayDate.TabIndex = 4;
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(300, 120);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(100, 20);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "توضیحات";
            labelDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(100, 120);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 31);
            textBoxDescription.TabIndex = 6;
            // 
            // labelReceiptNumber
            // 
            labelReceiptNumber.Location = new Point(300, 150);
            labelReceiptNumber.Name = "labelReceiptNumber";
            labelReceiptNumber.Size = new Size(100, 20);
            labelReceiptNumber.TabIndex = 7;
            labelReceiptNumber.Text = "شماره رسید";
            labelReceiptNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxReceiptNumber
            // 
            textBoxReceiptNumber.Location = new Point(100, 150);
            textBoxReceiptNumber.Name = "textBoxReceiptNumber";
            textBoxReceiptNumber.Size = new Size(200, 31);
            textBoxReceiptNumber.TabIndex = 8;
            // 
            // labelPaymentType
            // 
            labelPaymentType.Location = new Point(300, 180);
            labelPaymentType.Name = "labelPaymentType";
            labelPaymentType.Size = new Size(100, 20);
            labelPaymentType.TabIndex = 9;
            labelPaymentType.Text = "نوع پرداخت";
            labelPaymentType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxPaymentType
            // 
            comboBoxPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaymentType.Items.AddRange(new object[] { "کارت به کارت", "نقدی", "پوز" });
            comboBoxPaymentType.Location = new Point(100, 180);
            comboBoxPaymentType.Name = "comboBoxPaymentType";
            comboBoxPaymentType.Size = new Size(200, 33);
            comboBoxPaymentType.TabIndex = 10;
            // 
            // labelSessionCount
            // 
            labelSessionCount.Location = new Point(300, 210);
            labelSessionCount.Name = "labelSessionCount";
            labelSessionCount.Size = new Size(100, 20);
            labelSessionCount.TabIndex = 11;
            labelSessionCount.Text = "تعداد جلسات";
            labelSessionCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxSessionCount
            // 
            textBoxSessionCount.Location = new Point(100, 210);
            textBoxSessionCount.Name = "textBoxSessionCount";
            textBoxSessionCount.Size = new Size(200, 31);
            textBoxSessionCount.TabIndex = 12;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(150, 280);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "ذخیره";
            buttonSave.Click += ButtonSave_Click;
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.ColumnHeadersHeight = 34;
            dataGridViewPayments.Location = new Point(20, 318);
            dataGridViewPayments.MultiSelect = false;
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.RowHeadersWidth = 62;
            dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPayments.Size = new Size(760, 200);
            dataGridViewPayments.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(256, 280);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 13;
            btnClear.Text = "جدید";
            btnClear.Click += btnClear_Click;
            // 
            // labelTotalPayments
            // 
            labelTotalPayments.Location = new Point(20, 528);
            labelTotalPayments.Name = "labelTotalPayments";
            labelTotalPayments.Size = new Size(760, 37);
            labelTotalPayments.TabIndex = 15;
            labelTotalPayments.Text = "جمع مبالغ پرداختی: 0 تومان";
            labelTotalPayments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(300, 239);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 16;
            label1.Text = "تاریخ اعتبار";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtboxPaymentDateEnd
            // 
            txtboxPaymentDateEnd.Location = new Point(100, 239);
            txtboxPaymentDateEnd.Name = "txtboxPaymentDateEnd";
            txtboxPaymentDateEnd.Size = new Size(200, 31);
            txtboxPaymentDateEnd.TabIndex = 17;
            // 
            // FrmPaymentManagment
            // 
            ClientSize = new Size(793, 575);
            Controls.Add(label1);
            Controls.Add(txtboxPaymentDateEnd);
            Controls.Add(buttonSelectAthlete);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPayDate);
            Controls.Add(textBoxPayDate);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelReceiptNumber);
            Controls.Add(textBoxReceiptNumber);
            Controls.Add(labelPaymentType);
            Controls.Add(comboBoxPaymentType);
            Controls.Add(labelSessionCount);
            Controls.Add(textBoxSessionCount);
            Controls.Add(btnClear);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewPayments);
            Controls.Add(labelTotalPayments);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPaymentManagment";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ثبت پرداخت";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelReceiptNumber;
        private TextBox textBoxReceiptNumber;
        private Label labelPaymentType;
        private ComboBox comboBoxPaymentType;
        private Label labelSessionCount;
        private TextBox textBoxSessionCount;
        private Button buttonSave;
        private DataGridView dataGridViewPayments;
        private Button buttonSelectAthlete;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelPayDate;
        private Label labelTotalPayments;
        private TextBox textBoxPayDate;
        #endregion

        private Button btnClear;
        private Label label1;
        private TextBox txtboxPaymentDateEnd;
    }
}