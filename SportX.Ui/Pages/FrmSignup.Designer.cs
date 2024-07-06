using System;

namespace SportX.Ui.Pages
{
    partial class FrmSignup
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
            radioMilitray = new RadioButton();
            radioNormal = new RadioButton();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(847, 35);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 25);
            labelName.TabIndex = 0;
            labelName.Text = "نام";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(309, 30);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(474, 31);
            textBoxName.TabIndex = 1;
            // 
            // labelNationalCode
            // 
            labelNationalCode.AutoSize = true;
            labelNationalCode.Location = new Point(847, 82);
            labelNationalCode.Margin = new Padding(4, 0, 4, 0);
            labelNationalCode.Name = "labelNationalCode";
            labelNationalCode.Size = new Size(67, 25);
            labelNationalCode.TabIndex = 2;
            labelNationalCode.Text = "کد ملی";
            // 
            // textBoxNationalCode
            // 
            textBoxNationalCode.Location = new Point(309, 77);
            textBoxNationalCode.Margin = new Padding(4, 5, 4, 5);
            textBoxNationalCode.Name = "textBoxNationalCode";
            textBoxNationalCode.Size = new Size(474, 31);
            textBoxNationalCode.TabIndex = 3;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(847, 129);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(45, 25);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "تلفن";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(309, 124);
            textBoxPhone.Margin = new Padding(4, 5, 4, 5);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(474, 31);
            textBoxPhone.TabIndex = 5;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(847, 176);
            labelGender.Margin = new Padding(4, 0, 4, 0);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(67, 25);
            labelGender.TabIndex = 6;
            labelGender.Text = "جنسیت";
            // 
            // radioButtonMale
            // 
            radioButtonMale.Checked = true;
            radioButtonMale.Location = new Point(703, 171);
            radioButtonMale.Margin = new Padding(4, 5, 4, 5);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 38);
            radioButtonMale.TabIndex = 7;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "مرد";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.Location = new Point(603, 171);
            radioButtonFemale.Margin = new Padding(4, 5, 4, 5);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(75, 38);
            radioButtonFemale.TabIndex = 8;
            radioButtonFemale.Text = "زن";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(847, 279);
            labelDateOfBirth.Margin = new Padding(4, 0, 4, 0);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(85, 25);
            labelDateOfBirth.TabIndex = 9;
            labelDateOfBirth.Text = "تاریخ تولد";
            // 
            // textBoxDateOfBirth
            // 
            textBoxDateOfBirth.Location = new Point(309, 275);
            textBoxDateOfBirth.Margin = new Padding(4, 5, 4, 5);
            textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            textBoxDateOfBirth.Size = new Size(474, 31);
            textBoxDateOfBirth.TabIndex = 10;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(660, 342);
            buttonSignUp.Margin = new Padding(4, 5, 4, 5);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(94, 36);
            buttonSignUp.TabIndex = 11;
            buttonSignUp.Text = "ثبت نام";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += ButtonSignUp_Click;
            // 
            // dataGridViewAthletes
            // 
            dataGridViewAthletes.AllowUserToAddRows = false;
            dataGridViewAthletes.AllowUserToDeleteRows = false;
            dataGridViewAthletes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAthletes.Dock = DockStyle.Bottom;
            dataGridViewAthletes.Location = new Point(0, 411);
            dataGridViewAthletes.Margin = new Padding(4, 5, 4, 5);
            dataGridViewAthletes.Name = "dataGridViewAthletes";
            dataGridViewAthletes.ReadOnly = true;
            dataGridViewAthletes.RowHeadersWidth = 51;
            dataGridViewAthletes.RowTemplate.Height = 24;
            dataGridViewAthletes.Size = new Size(965, 288);
            dataGridViewAthletes.TabIndex = 12;
            dataGridViewAthletes.SelectionChanged += DataGridViewAthletes_SelectionChanged;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(762, 342);
            buttonNew.Margin = new Padding(4, 5, 4, 5);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(94, 36);
            buttonNew.TabIndex = 11;
            buttonNew.Text = "جدید";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // radioMilitray
            // 
            radioMilitray.Location = new Point(566, 219);
            radioMilitray.Margin = new Padding(4, 5, 4, 5);
            radioMilitray.Name = "radioMilitray";
            radioMilitray.Size = new Size(92, 38);
            radioMilitray.TabIndex = 15;
            radioMilitray.Text = "نظامی";
            radioMilitray.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            radioNormal.Checked = true;
            radioNormal.Location = new Point(678, 219);
            radioNormal.Margin = new Padding(4, 5, 4, 5);
            radioNormal.Name = "radioNormal";
            radioNormal.Size = new Size(100, 38);
            radioNormal.TabIndex = 14;
            radioNormal.TabStop = true;
            radioNormal.Text = "معمولی";
            radioNormal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(847, 224);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 13;
            label1.Text = "نوع عضویت";
            // 
            // panel1
            // 
            panel1.Location = new Point(104, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 16;
            // 
            // FrmSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 699);
            Controls.Add(panel1);
            Controls.Add(radioMilitray);
            Controls.Add(radioNormal);
            Controls.Add(label1);
            Controls.Add(dataGridViewAthletes);
            Controls.Add(buttonNew);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxDateOfBirth);
            Controls.Add(labelDateOfBirth);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
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
            Text = "ثبت نام ورزشکار";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

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
        #endregion

        private Button buttonNew;
        private RadioButton radioMilitray;
        private RadioButton radioNormal;
        private Label label1;
        private Panel panel1;
    }
}