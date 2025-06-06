using SportX.Ui.Properties;

namespace SportX.Ui
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonCancel = new Button();
            pictureBoxLogo = new PictureBox();
            persianDatePicker1 = new SportX.Ui.Components.PersianDatePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(326, 203);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(115, 29);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "نام کاربری";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(326, 282);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(94, 29);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "رمز عبور";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(61, 198);
            textBoxUsername.Margin = new Padding(4, 5, 4, 5);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(250, 36);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(61, 277);
            textBoxPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(250, 36);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.MediumSeaGreen;
            buttonLogin.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(61, 358);
            buttonLogin.Margin = new Padding(4, 5, 4, 5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(119, 55);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "ورود";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Crimson;
            buttonCancel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(194, 358);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(119, 55);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "لغو";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(189, 17);
            pictureBoxLogo.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(126, 157);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // persianDatePicker1
            // 
            persianDatePicker1.Location = new Point(13, 41);
            persianDatePicker1.Margin = new Padding(4, 5, 4, 5);
            persianDatePicker1.Name = "persianDatePicker1";
            persianDatePicker1.Size = new Size(450, 650);
            persianDatePicker1.TabIndex = 7;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 468);
            Controls.Add(persianDatePicker1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmLogin";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ورود";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonCancel;
        private PictureBox pictureBoxLogo;
        #endregion

        private Components.PersianDatePicker persianDatePicker1;
    }
}
