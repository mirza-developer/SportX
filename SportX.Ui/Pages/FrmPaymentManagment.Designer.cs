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
            components = new System.ComponentModel.Container();
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
            label2 = new Label();
            textBoxAthleteName = new TextBox();
            menuGridOptions = new ContextMenuStrip(components);
            textBoxEpc = new TextBox();
            buttonEpc = new Button();
            timerFocus = new System.Windows.Forms.Timer(components);
            labelPlan = new Label();
            comboBoxPlan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // buttonSelectAthlete
            // 
            buttonSelectAthlete.Location = new Point(392, 16);
            buttonSelectAthlete.Name = "buttonSelectAthlete";
            buttonSelectAthlete.Size = new Size(119, 34);
            buttonSelectAthlete.TabIndex = 0;
            buttonSelectAthlete.Text = "انتخاب ورزشکار";
            buttonSelectAthlete.Click += ButtonSelectAthlete_Click;
            // 
            // labelPrice
            // 
            labelPrice.Location = new Point(408, 97);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(100, 27);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "مبلغ (تومان)";
            labelPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(108, 97);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(300, 31);
            textBoxPrice.TabIndex = 2;
            // 
            // labelPayDate
            // 
            labelPayDate.Location = new Point(817, 97);
            labelPayDate.Name = "labelPayDate";
            labelPayDate.Size = new Size(100, 27);
            labelPayDate.TabIndex = 3;
            labelPayDate.Text = "تاریخ پرداخت";
            labelPayDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxPayDate
            // 
            textBoxPayDate.Location = new Point(517, 97);
            textBoxPayDate.Name = "textBoxPayDate";
            textBoxPayDate.Size = new Size(300, 31);
            textBoxPayDate.TabIndex = 4;
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(817, 134);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(100, 27);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "توضیحات";
            labelDescription.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(517, 134);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(300, 31);
            textBoxDescription.TabIndex = 6;
            // 
            // labelReceiptNumber
            // 
            labelReceiptNumber.Location = new Point(817, 171);
            labelReceiptNumber.Name = "labelReceiptNumber";
            labelReceiptNumber.Size = new Size(100, 27);
            labelReceiptNumber.TabIndex = 7;
            labelReceiptNumber.Text = "شماره رسید";
            labelReceiptNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxReceiptNumber
            // 
            textBoxReceiptNumber.Location = new Point(517, 171);
            textBoxReceiptNumber.Name = "textBoxReceiptNumber";
            textBoxReceiptNumber.Size = new Size(300, 31);
            textBoxReceiptNumber.TabIndex = 8;
            // 
            // labelPaymentType
            // 
            labelPaymentType.Location = new Point(817, 208);
            labelPaymentType.Name = "labelPaymentType";
            labelPaymentType.Size = new Size(100, 27);
            labelPaymentType.TabIndex = 9;
            labelPaymentType.Text = "نوع پرداخت";
            labelPaymentType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxPaymentType
            // 
            comboBoxPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaymentType.Items.AddRange(new object[] { "کارت به کارت", "نقدی", "پوز" });
            comboBoxPaymentType.Location = new Point(517, 208);
            comboBoxPaymentType.Name = "comboBoxPaymentType";
            comboBoxPaymentType.Size = new Size(300, 33);
            comboBoxPaymentType.TabIndex = 10;
            // 
            // labelSessionCount
            // 
            labelSessionCount.Location = new Point(408, 134);
            labelSessionCount.Name = "labelSessionCount";
            labelSessionCount.Size = new Size(100, 27);
            labelSessionCount.TabIndex = 11;
            labelSessionCount.Text = "تعداد جلسات";
            labelSessionCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxSessionCount
            // 
            textBoxSessionCount.Location = new Point(108, 134);
            textBoxSessionCount.Name = "textBoxSessionCount";
            textBoxSessionCount.Size = new Size(300, 31);
            textBoxSessionCount.TabIndex = 12;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 281);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 33);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "ذخیره";
            buttonSave.Click += ButtonSave_Click;
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.ColumnHeadersHeight = 34;
            dataGridViewPayments.Location = new Point(12, 318);
            dataGridViewPayments.MultiSelect = false;
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.RowHeadersVisible = false;
            dataGridViewPayments.RowHeadersWidth = 62;
            dataGridViewPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPayments.Size = new Size(909, 282);
            dataGridViewPayments.TabIndex = 14;
            dataGridViewPayments.MouseDown += dataGridViewPayments_MouseDown;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(118, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 33);
            btnClear.TabIndex = 13;
            btnClear.Text = "جدید";
            btnClear.Click += btnClear_Click;
            // 
            // labelTotalPayments
            // 
            labelTotalPayments.Location = new Point(20, 603);
            labelTotalPayments.Name = "labelTotalPayments";
            labelTotalPayments.Size = new Size(901, 37);
            labelTotalPayments.TabIndex = 15;
            labelTotalPayments.Text = "جمع مبالغ پرداختی: 0 تومان";
            labelTotalPayments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(408, 171);
            label1.Name = "label1";
            label1.Size = new Size(100, 27);
            label1.TabIndex = 16;
            label1.Text = "تاریخ اعتبار";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtboxPaymentDateEnd
            // 
            txtboxPaymentDateEnd.Location = new Point(108, 171);
            txtboxPaymentDateEnd.Name = "txtboxPaymentDateEnd";
            txtboxPaymentDateEnd.Size = new Size(300, 31);
            txtboxPaymentDateEnd.TabIndex = 17;
            // 
            // label2
            // 
            label2.Location = new Point(817, 23);
            label2.Name = "label2";
            label2.Size = new Size(100, 27);
            label2.TabIndex = 18;
            label2.Text = "ورزشکار";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxAthleteName
            // 
            textBoxAthleteName.Location = new Point(517, 23);
            textBoxAthleteName.Name = "textBoxAthleteName";
            textBoxAthleteName.ReadOnly = true;
            textBoxAthleteName.Size = new Size(300, 31);
            textBoxAthleteName.TabIndex = 19;
            // 
            // menuGridOptions
            // 
            menuGridOptions.ImageScalingSize = new Size(24, 24);
            menuGridOptions.Name = "menuGridOptions";
            menuGridOptions.Size = new Size(61, 4);
            // 
            // textBoxEpc
            // 
            textBoxEpc.Location = new Point(108, 26);
            textBoxEpc.Name = "textBoxEpc";
            textBoxEpc.Size = new Size(0, 31);
            textBoxEpc.TabIndex = 30;
            textBoxEpc.KeyDown += textBoxEpc_KeyDown;
            // 
            // buttonEpc
            // 
            buttonEpc.Location = new Point(331, 16);
            buttonEpc.Name = "buttonEpc";
            buttonEpc.Size = new Size(55, 34);
            buttonEpc.TabIndex = 31;
            buttonEpc.Text = "قرائت";
            buttonEpc.UseVisualStyleBackColor = true;
            buttonEpc.Click += buttonEpc_Click;
            // 
            // timerFocus
            // 
            timerFocus.Interval = 500;
            timerFocus.Tick += timerFocus_Tick;
            // 
            // labelPlan
            // 
            labelPlan.Location = new Point(817, 60);
            labelPlan.Name = "labelPlan";
            labelPlan.Size = new Size(100, 27);
            labelPlan.TabIndex = 20;
            labelPlan.Text = "پلن";
            labelPlan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxPlan
            // 
            comboBoxPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlan.Location = new Point(517, 60);
            comboBoxPlan.Name = "comboBoxPlan";
            comboBoxPlan.Size = new Size(300, 33);
            comboBoxPlan.TabIndex = 21;
            comboBoxPlan.SelectedIndexChanged += comboBoxPlan_SelectedIndexChanged;
            // 
            // FrmPaymentManagment
            // 
            ClientSize = new Size(933, 642);
            Controls.Add(buttonEpc);
            Controls.Add(textBoxEpc);
            Controls.Add(label2);
            Controls.Add(textBoxAthleteName);
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
            Controls.Add(labelPlan);
            Controls.Add(comboBoxPlan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPaymentManagment";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ثبت پرداخت";
            Load += FrmPaymentManagment_Load;
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
        private Label label2;
        private TextBox textBoxAthleteName;
        private ContextMenuStrip menuGridOptions;
        private TextBox textBoxEpc;
        private Button buttonEpc;
        private System.Windows.Forms.Timer timerFocus;
        private ComboBox comboBoxPlan;
        private Label labelPlan;
    }
}