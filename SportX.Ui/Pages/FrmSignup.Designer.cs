namespace SportX.Ui.Pages;
partial class FrmSignup
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignup));
        labelName = new Label();
        textBoxName = new TextBox();
        labelNationalCode = new Label();
        textBoxNationalCode = new TextBox();
        labelPhone = new Label();
        textBoxPhone = new TextBox();
        labelGender = new Label();
        radioButtonMale = new RadioButton();
        radioButtonFemale = new RadioButton();
        labelDateOfBirth = new Label();
        textBoxDateOfBirth = new TextBox();
        buttonSignUp = new Button();
        dataGridViewAthletes = new DataGridView();
        buttonNew = new Button();
        label1 = new Label();
        panel1 = new Panel();
        panel2 = new Panel();
        radioNormal = new RadioButton();
        radioMilitray = new RadioButton();
        textBoxId = new TextBox();
        label2 = new Label();
        groupBox1 = new GroupBox();
        buttonSearch = new Button();
        textBoxSearch = new TextBox();
        label3 = new Label();
        buttonPayments = new Button();
        textBoxAddress = new TextBox();
        label4 = new Label();
        textBoxEpc = new TextBox();
        label5 = new Label();
        buttonEpc = new Button();
        timerFocus = new System.Windows.Forms.Timer(components);
        buttonDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(897, 68);
        labelName.Margin = new Padding(4, 0, 4, 0);
        labelName.Name = "labelName";
        labelName.Size = new Size(34, 25);
        labelName.TabIndex = 0;
        labelName.Text = "نام";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(417, 63);
        textBoxName.Margin = new Padding(4, 5, 4, 5);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(474, 31);
        textBoxName.TabIndex = 1;
        // 
        // labelNationalCode
        // 
        labelNationalCode.AutoSize = true;
        labelNationalCode.Location = new Point(897, 117);
        labelNationalCode.Margin = new Padding(4, 0, 4, 0);
        labelNationalCode.Name = "labelNationalCode";
        labelNationalCode.Size = new Size(67, 25);
        labelNationalCode.TabIndex = 2;
        labelNationalCode.Text = "کد ملی";
        // 
        // textBoxNationalCode
        // 
        textBoxNationalCode.Location = new Point(417, 112);
        textBoxNationalCode.Margin = new Padding(4, 5, 4, 5);
        textBoxNationalCode.Name = "textBoxNationalCode";
        textBoxNationalCode.Size = new Size(474, 31);
        textBoxNationalCode.TabIndex = 3;
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Location = new Point(897, 163);
        labelPhone.Margin = new Padding(4, 0, 4, 0);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(45, 25);
        labelPhone.TabIndex = 4;
        labelPhone.Text = "تلفن";
        // 
        // textBoxPhone
        // 
        textBoxPhone.Location = new Point(417, 158);
        textBoxPhone.Margin = new Padding(4, 5, 4, 5);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(474, 31);
        textBoxPhone.TabIndex = 5;
        // 
        // labelGender
        // 
        labelGender.AutoSize = true;
        labelGender.Location = new Point(897, 273);
        labelGender.Margin = new Padding(4, 0, 4, 0);
        labelGender.Name = "labelGender";
        labelGender.Size = new Size(67, 25);
        labelGender.TabIndex = 6;
        labelGender.Text = "جنسیت";
        // 
        // radioButtonMale
        // 
        radioButtonMale.Checked = true;
        radioButtonMale.Location = new Point(197, 5);
        radioButtonMale.Margin = new Padding(4, 5, 4, 5);
        radioButtonMale.Name = "radioButtonMale";
        radioButtonMale.Size = new Size(74, 38);
        radioButtonMale.TabIndex = 7;
        radioButtonMale.TabStop = true;
        radioButtonMale.Text = "مرد";
        radioButtonMale.UseVisualStyleBackColor = true;
        // 
        // radioButtonFemale
        // 
        radioButtonFemale.Location = new Point(86, 5);
        radioButtonFemale.Margin = new Padding(4, 5, 4, 5);
        radioButtonFemale.Name = "radioButtonFemale";
        radioButtonFemale.Size = new Size(77, 38);
        radioButtonFemale.TabIndex = 8;
        radioButtonFemale.Text = "زن";
        radioButtonFemale.UseVisualStyleBackColor = true;
        // 
        // labelDateOfBirth
        // 
        labelDateOfBirth.AutoSize = true;
        labelDateOfBirth.Location = new Point(894, 325);
        labelDateOfBirth.Margin = new Padding(4, 0, 4, 0);
        labelDateOfBirth.Name = "labelDateOfBirth";
        labelDateOfBirth.Size = new Size(85, 25);
        labelDateOfBirth.TabIndex = 9;
        labelDateOfBirth.Text = "تاریخ تولد";
        // 
        // textBoxDateOfBirth
        // 
        textBoxDateOfBirth.Location = new Point(700, 320);
        textBoxDateOfBirth.Margin = new Padding(4, 5, 4, 5);
        textBoxDateOfBirth.Name = "textBoxDateOfBirth";
        textBoxDateOfBirth.Size = new Size(188, 31);
        textBoxDateOfBirth.TabIndex = 10;
        // 
        // buttonSignUp
        // 
        buttonSignUp.Location = new Point(306, 430);
        buttonSignUp.Margin = new Padding(4, 5, 4, 5);
        buttonSignUp.Name = "buttonSignUp";
        buttonSignUp.Size = new Size(79, 43);
        buttonSignUp.TabIndex = 11;
        buttonSignUp.Text = "ثبت";
        buttonSignUp.UseVisualStyleBackColor = true;
        buttonSignUp.Click += ButtonSignUp_Click;
        // 
        // dataGridViewAthletes
        // 
        dataGridViewAthletes.AllowUserToAddRows = false;
        dataGridViewAthletes.AllowUserToDeleteRows = false;
        dataGridViewAthletes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewAthletes.BackgroundColor = Color.LightGray;
        dataGridViewAthletes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewAthletes.Dock = DockStyle.Bottom;
        dataGridViewAthletes.Location = new Point(0, 579);
        dataGridViewAthletes.Margin = new Padding(4, 5, 4, 5);
        dataGridViewAthletes.MultiSelect = false;
        dataGridViewAthletes.Name = "dataGridViewAthletes";
        dataGridViewAthletes.ReadOnly = true;
        dataGridViewAthletes.RowHeadersVisible = false;
        dataGridViewAthletes.RowHeadersWidth = 62;
        dataGridViewAthletes.RowTemplate.Height = 25;
        dataGridViewAthletes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewAthletes.Size = new Size(1073, 428);
        dataGridViewAthletes.TabIndex = 12;
        dataGridViewAthletes.SelectionChanged += DataGridViewAthletes_SelectionChanged;
        // 
        // buttonNew
        // 
        buttonNew.Location = new Point(219, 430);
        buttonNew.Margin = new Padding(4, 5, 4, 5);
        buttonNew.Name = "buttonNew";
        buttonNew.Size = new Size(79, 43);
        buttonNew.TabIndex = 13;
        buttonNew.Text = "جدید";
        buttonNew.UseVisualStyleBackColor = true;
        buttonNew.Click += buttonNew_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(897, 380);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(106, 25);
        label1.TabIndex = 14;
        label1.Text = "نوع عضویت";
        // 
        // panel1
        // 
        panel1.Controls.Add(radioButtonMale);
        panel1.Controls.Add(radioButtonFemale);
        panel1.Location = new Point(600, 262);
        panel1.Name = "panel1";
        panel1.Size = new Size(290, 50);
        panel1.TabIndex = 15;
        // 
        // panel2
        // 
        panel2.Controls.Add(radioNormal);
        panel2.Controls.Add(radioMilitray);
        panel2.Location = new Point(600, 367);
        panel2.Name = "panel2";
        panel2.Size = new Size(290, 50);
        panel2.TabIndex = 16;
        // 
        // radioNormal
        // 
        radioNormal.Checked = true;
        radioNormal.Location = new Point(194, 7);
        radioNormal.Margin = new Padding(4, 5, 4, 5);
        radioNormal.Name = "radioNormal";
        radioNormal.Size = new Size(77, 38);
        radioNormal.TabIndex = 8;
        radioNormal.TabStop = true;
        radioNormal.Text = "عادی";
        radioNormal.UseVisualStyleBackColor = true;
        // 
        // radioMilitray
        // 
        radioMilitray.Location = new Point(74, 7);
        radioMilitray.Margin = new Padding(4, 5, 4, 5);
        radioMilitray.Name = "radioMilitray";
        radioMilitray.Size = new Size(89, 38);
        radioMilitray.TabIndex = 7;
        radioMilitray.Text = "نظامی";
        radioMilitray.UseVisualStyleBackColor = true;
        // 
        // textBoxId
        // 
        textBoxId.Location = new Point(703, 15);
        textBoxId.Margin = new Padding(4, 5, 4, 5);
        textBoxId.Name = "textBoxId";
        textBoxId.ReadOnly = true;
        textBoxId.Size = new Size(188, 31);
        textBoxId.TabIndex = 18;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(897, 20);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(30, 25);
        label2.TabIndex = 17;
        label2.Text = "کد";
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(buttonSearch);
        groupBox1.Location = new Point(17, 495);
        groupBox1.Margin = new Padding(4, 5, 4, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 5, 4, 5);
        groupBox1.Size = new Size(1039, 75);
        groupBox1.TabIndex = 19;
        groupBox1.TabStop = false;
        groupBox1.Text = "جستجو";
        // 
        // buttonSearch
        // 
        buttonSearch.Location = new Point(314, 22);
        buttonSearch.Margin = new Padding(4, 5, 4, 5);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(77, 43);
        buttonSearch.TabIndex = 22;
        buttonSearch.Text = "جستجو";
        buttonSearch.UseVisualStyleBackColor = true;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // textBoxSearch
        // 
        textBoxSearch.Location = new Point(417, 522);
        textBoxSearch.Margin = new Padding(4, 5, 4, 5);
        textBoxSearch.Name = "textBoxSearch";
        textBoxSearch.Size = new Size(474, 31);
        textBoxSearch.TabIndex = 21;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(897, 527);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(148, 25);
        label3.TabIndex = 20;
        label3.Text = "نام/کدملی/شناسه";
        // 
        // buttonPayments
        // 
        buttonPayments.Location = new Point(17, 430);
        buttonPayments.Margin = new Padding(4, 5, 4, 5);
        buttonPayments.Name = "buttonPayments";
        buttonPayments.Size = new Size(106, 43);
        buttonPayments.TabIndex = 22;
        buttonPayments.Text = "پرداخت ها";
        buttonPayments.UseVisualStyleBackColor = true;
        buttonPayments.Click += buttonPayments_Click;
        // 
        // textBoxAddress
        // 
        textBoxAddress.Location = new Point(417, 212);
        textBoxAddress.Margin = new Padding(4, 5, 4, 5);
        textBoxAddress.Name = "textBoxAddress";
        textBoxAddress.Size = new Size(474, 31);
        textBoxAddress.TabIndex = 24;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(897, 217);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(53, 25);
        label4.TabIndex = 23;
        label4.Text = "آدرس";
        // 
        // textBoxEpc
        // 
        textBoxEpc.Location = new Point(510, 430);
        textBoxEpc.Margin = new Padding(4, 5, 4, 5);
        textBoxEpc.Name = "textBoxEpc";
        textBoxEpc.ReadOnly = true;
        textBoxEpc.Size = new Size(381, 31);
        textBoxEpc.TabIndex = 26;
        textBoxEpc.KeyDown += textBoxEpc_KeyDown;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(897, 435);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(104, 25);
        label5.TabIndex = 25;
        label5.Text = "شناسه کارت";
        // 
        // buttonEpc
        // 
        buttonEpc.Location = new Point(423, 425);
        buttonEpc.Margin = new Padding(4, 5, 4, 5);
        buttonEpc.Name = "buttonEpc";
        buttonEpc.Size = new Size(79, 43);
        buttonEpc.TabIndex = 27;
        buttonEpc.Text = "قرائت";
        buttonEpc.UseVisualStyleBackColor = true;
        buttonEpc.Click += buttonEpc_Click;
        // 
        // timerFocus
        // 
        timerFocus.Interval = 500;
        timerFocus.Tick += timerFocus_Tick;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new Point(132, 430);
        buttonDelete.Margin = new Padding(4, 5, 4, 5);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(79, 43);
        buttonDelete.TabIndex = 28;
        buttonDelete.Text = "حذف";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // FrmSignup
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1073, 1007);
        Controls.Add(buttonDelete);
        Controls.Add(buttonEpc);
        Controls.Add(textBoxEpc);
        Controls.Add(label5);
        Controls.Add(textBoxAddress);
        Controls.Add(label4);
        Controls.Add(buttonPayments);
        Controls.Add(textBoxSearch);
        Controls.Add(label3);
        Controls.Add(groupBox1);
        Controls.Add(textBoxId);
        Controls.Add(label2);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(label1);
        Controls.Add(buttonNew);
        Controls.Add(dataGridViewAthletes);
        Controls.Add(buttonSignUp);
        Controls.Add(textBoxDateOfBirth);
        Controls.Add(labelDateOfBirth);
        Controls.Add(labelGender);
        Controls.Add(textBoxPhone);
        Controls.Add(labelPhone);
        Controls.Add(textBoxNationalCode);
        Controls.Add(labelNationalCode);
        Controls.Add(textBoxName);
        Controls.Add(labelName);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 5, 4, 5);
        Name = "FrmSignup";
        RightToLeft = RightToLeft.Yes;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ثبت نام ورزشکاران";
        ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelName;
    private TextBox textBoxName;
    private Label labelNationalCode;
    private TextBox textBoxNationalCode;
    private Label labelPhone;
    private TextBox textBoxPhone;
    private Label labelGender;
    private RadioButton radioButtonMale;
    private RadioButton radioButtonFemale;
    private Label labelDateOfBirth;
    private TextBox textBoxDateOfBirth;
    private Button buttonSignUp;
    private DataGridView dataGridViewAthletes;
    private Button buttonNew;
    private Label label1;
    private Panel panel1;
    private RadioButton radioNormal;
    private RadioButton radioMilitray;
    private Panel panel2;
    private TextBox textBoxId;
    private Label label2;
    private GroupBox groupBox1;
    private TextBox textBoxSearch;
    private Label label3;
    private Button buttonSearch;
    private Button buttonPayments;
    private TextBox textBoxAddress;
    private Label label4;
    private TextBox textBoxEpc;
    private Label label5;
    private Button buttonEpc;
    private System.Windows.Forms.Timer timerFocus;
    private Button buttonDelete;
}
