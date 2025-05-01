using SportX.Ui.Parking.Properties;

namespace SportX.Ui.Parking.Pages
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(228, 122);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(76, 19);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "نام کاربری";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(228, 169);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(63, 19);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "رمز عبور";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(43, 119);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(176, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(43, 166);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(176, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.MediumSeaGreen;
            buttonLogin.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(43, 215);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(83, 33);
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
            buttonCancel.Location = new Point(136, 215);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(83, 33);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "لغو";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.Logo;
            pictureBoxLogo.Location = new Point(132, 10);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(88, 94);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 281);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ورود";
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
    }
}
