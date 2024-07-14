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
        ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(628, 41);
        labelName.Name = "labelName";
        labelName.Size = new Size(21, 15);
        labelName.TabIndex = 0;
        labelName.Text = "نام";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(292, 38);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(333, 23);
        textBoxName.TabIndex = 1;
        // 
        // labelNationalCode
        // 
        labelNationalCode.AutoSize = true;
        labelNationalCode.Location = new Point(628, 70);
        labelNationalCode.Name = "labelNationalCode";
        labelNationalCode.Size = new Size(43, 15);
        labelNationalCode.TabIndex = 2;
        labelNationalCode.Text = "کد ملی";
        // 
        // textBoxNationalCode
        // 
        textBoxNationalCode.Location = new Point(292, 67);
        textBoxNationalCode.Name = "textBoxNationalCode";
        textBoxNationalCode.Size = new Size(333, 23);
        textBoxNationalCode.TabIndex = 3;
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Location = new Point(628, 98);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(29, 15);
        labelPhone.TabIndex = 4;
        labelPhone.Text = "تلفن";
        // 
        // textBoxPhone
        // 
        textBoxPhone.Location = new Point(292, 95);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(333, 23);
        textBoxPhone.TabIndex = 5;
        // 
        // labelGender
        // 
        labelGender.AutoSize = true;
        labelGender.Location = new Point(628, 127);
        labelGender.Name = "labelGender";
        labelGender.Size = new Size(43, 15);
        labelGender.TabIndex = 6;
        labelGender.Text = "جنسیت";
        // 
        // radioButtonMale
        // 
        radioButtonMale.Checked = true;
        radioButtonMale.Location = new Point(138, 3);
        radioButtonMale.Name = "radioButtonMale";
        radioButtonMale.Size = new Size(52, 23);
        radioButtonMale.TabIndex = 7;
        radioButtonMale.TabStop = true;
        radioButtonMale.Text = "مرد";
        radioButtonMale.UseVisualStyleBackColor = true;
        // 
        // radioButtonFemale
        // 
        radioButtonFemale.Location = new Point(60, 3);
        radioButtonFemale.Name = "radioButtonFemale";
        radioButtonFemale.Size = new Size(54, 23);
        radioButtonFemale.TabIndex = 8;
        radioButtonFemale.Text = "زن";
        radioButtonFemale.UseVisualStyleBackColor = true;
        // 
        // labelDateOfBirth
        // 
        labelDateOfBirth.AutoSize = true;
        labelDateOfBirth.Location = new Point(628, 155);
        labelDateOfBirth.Name = "labelDateOfBirth";
        labelDateOfBirth.Size = new Size(54, 15);
        labelDateOfBirth.TabIndex = 9;
        labelDateOfBirth.Text = "تاریخ تولد";
        // 
        // textBoxDateOfBirth
        // 
        textBoxDateOfBirth.Location = new Point(292, 152);
        textBoxDateOfBirth.Name = "textBoxDateOfBirth";
        textBoxDateOfBirth.Size = new Size(333, 23);
        textBoxDateOfBirth.TabIndex = 10;
        // 
        // buttonSignUp
        // 
        buttonSignUp.Location = new Point(337, 221);
        buttonSignUp.Name = "buttonSignUp";
        buttonSignUp.Size = new Size(136, 26);
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
        dataGridViewAthletes.Location = new Point(0, 304);
        dataGridViewAthletes.MultiSelect = false;
        dataGridViewAthletes.Name = "dataGridViewAthletes";
        dataGridViewAthletes.ReadOnly = true;
        dataGridViewAthletes.RowHeadersVisible = false;
        dataGridViewAthletes.RowHeadersWidth = 62;
        dataGridViewAthletes.RowTemplate.Height = 25;
        dataGridViewAthletes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewAthletes.Size = new Size(745, 257);
        dataGridViewAthletes.TabIndex = 12;
        dataGridViewAthletes.SelectionChanged += DataGridViewAthletes_SelectionChanged;
        // 
        // buttonNew
        // 
        buttonNew.Location = new Point(498, 221);
        buttonNew.Name = "buttonNew";
        buttonNew.Size = new Size(136, 26);
        buttonNew.TabIndex = 13;
        buttonNew.Text = "جدید";
        buttonNew.UseVisualStyleBackColor = true;
        buttonNew.Click += buttonNew_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(628, 183);
        label1.Name = "label1";
        label1.Size = new Size(68, 15);
        label1.TabIndex = 14;
        label1.Text = "نوع عضویت";
        // 
        // panel1
        // 
        panel1.Controls.Add(radioButtonMale);
        panel1.Controls.Add(radioButtonFemale);
        panel1.Location = new Point(420, 120);
        panel1.Margin = new Padding(2);
        panel1.Name = "panel1";
        panel1.Size = new Size(203, 30);
        panel1.TabIndex = 15;
        // 
        // panel2
        // 
        panel2.Controls.Add(radioNormal);
        panel2.Controls.Add(radioMilitray);
        panel2.Location = new Point(420, 183);
        panel2.Margin = new Padding(2);
        panel2.Name = "panel2";
        panel2.Size = new Size(203, 30);
        panel2.TabIndex = 16;
        // 
        // radioNormal
        // 
        radioNormal.Checked = true;
        radioNormal.Location = new Point(136, 4);
        radioNormal.Name = "radioNormal";
        radioNormal.Size = new Size(54, 23);
        radioNormal.TabIndex = 8;
        radioNormal.TabStop = true;
        radioNormal.Text = "عادی";
        radioNormal.UseVisualStyleBackColor = true;
        // 
        // radioMilitray
        // 
        radioMilitray.Location = new Point(52, 4);
        radioMilitray.Name = "radioMilitray";
        radioMilitray.Size = new Size(62, 23);
        radioMilitray.TabIndex = 7;
        radioMilitray.Text = "نظامی";
        radioMilitray.UseVisualStyleBackColor = true;
        // 
        // textBoxId
        // 
        textBoxId.Location = new Point(492, 9);
        textBoxId.Name = "textBoxId";
        textBoxId.ReadOnly = true;
        textBoxId.Size = new Size(133, 23);
        textBoxId.TabIndex = 18;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(628, 12);
        label2.Name = "label2";
        label2.Size = new Size(19, 15);
        label2.TabIndex = 17;
        label2.Text = "کد";
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        groupBox1.Controls.Add(buttonSearch);
        groupBox1.Location = new Point(12, 253);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(721, 45);
        groupBox1.TabIndex = 19;
        groupBox1.TabStop = false;
        groupBox1.Text = "جستجو";
        // 
        // buttonSearch
        // 
        buttonSearch.Location = new Point(220, 13);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(54, 26);
        buttonSearch.TabIndex = 22;
        buttonSearch.Text = "جستجو";
        buttonSearch.UseVisualStyleBackColor = true;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // textBoxSearch
        // 
        textBoxSearch.Location = new Point(292, 269);
        textBoxSearch.Name = "textBoxSearch";
        textBoxSearch.Size = new Size(333, 23);
        textBoxSearch.TabIndex = 21;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(628, 272);
        label3.Name = "label3";
        label3.Size = new Size(97, 15);
        label3.TabIndex = 20;
        label3.Text = "نام/کدملی/شناسه";
        // 
        // buttonPayments
        // 
        buttonPayments.Location = new Point(177, 221);
        buttonPayments.Name = "buttonPayments";
        buttonPayments.Size = new Size(136, 26);
        buttonPayments.TabIndex = 22;
        buttonPayments.Text = "مشاهده پرداخت ها";
        buttonPayments.UseVisualStyleBackColor = true;
        buttonPayments.Click += buttonPayments_Click;
        // 
        // FrmSignup
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(745, 561);
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
}
