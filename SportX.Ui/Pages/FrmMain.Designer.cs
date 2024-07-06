using Microsoft.EntityFrameworkCore;
using SportX.Ui.Models;

namespace SportX.Ui.Pages
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            labelNationalCode = new Label();
            textBoxNationalCode = new TextBox();
            buttonCheck = new Button();
            labelInfo = new Label();
            menuStrip = new MenuStrip();
            signUpMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // labelNationalCode
            // 
            labelNationalCode.AutoSize = true;
            labelNationalCode.Location = new Point(562, 94);
            labelNationalCode.Margin = new Padding(4, 0, 4, 0);
            labelNationalCode.Name = "labelNationalCode";
            labelNationalCode.Size = new Size(134, 25);
            labelNationalCode.TabIndex = 1;
            labelNationalCode.Text = "کد ملی / شناسه";
            // 
            // textBoxNationalCode
            // 
            textBoxNationalCode.Location = new Point(338, 89);
            textBoxNationalCode.Margin = new Padding(4, 5, 4, 5);
            textBoxNationalCode.Name = "textBoxNationalCode";
            textBoxNationalCode.Size = new Size(186, 31);
            textBoxNationalCode.TabIndex = 2;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(412, 156);
            buttonCheck.Margin = new Padding(4, 5, 4, 5);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(94, 36);
            buttonCheck.TabIndex = 3;
            buttonCheck.Text = "بررسی";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += ButtonCheck_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(338, 219);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 25);
            labelInfo.TabIndex = 4;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { signUpMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(750, 35);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // signUpMenuItem
            // 
            signUpMenuItem.Name = "signUpMenuItem";
            signUpMenuItem.Size = new Size(84, 29);
            signUpMenuItem.Text = "ثبت نام";
            signUpMenuItem.Click += SignUpMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 625);
            Controls.Add(labelInfo);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxNationalCode);
            Controls.Add(labelNationalCode);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه اصلی";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelNationalCode;
        private TextBox textBoxNationalCode;
        private Button buttonCheck;
        private Label labelInfo;
        private MenuStrip menuStrip;
        private ToolStripMenuItem signUpMenuItem;

        #endregion
    }
}