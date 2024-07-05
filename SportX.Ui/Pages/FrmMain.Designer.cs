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
            this.labelNationalCode = new Label();
            this.textBoxNationalCode = new TextBox();
            this.buttonCheck = new Button();
            this.labelInfo = new Label();
            this.SuspendLayout();

            // 
            // labelNationalCode
            // 
            this.labelNationalCode.AutoSize = true;
            this.labelNationalCode.Location = new Point(200, 30);
            this.labelNationalCode.Name = "labelNationalCode";
            this.labelNationalCode.Size = new Size(70, 17);
            this.labelNationalCode.TabIndex = 0;
            this.labelNationalCode.Text = "کد ملی / شناسه";

            // 
            // textBoxNationalCode
            // 
            this.textBoxNationalCode.Location = new Point(20, 27);
            this.textBoxNationalCode.Name = "textBoxNationalCode";
            this.textBoxNationalCode.Size = new Size(150, 22);
            this.textBoxNationalCode.TabIndex = 1;

            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new Point(80, 70);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new Size(75, 23);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "بررسی";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new EventHandler(this.ButtonCheck_Click);

            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new Point(20, 120);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new Size(0, 17);
            this.labelInfo.TabIndex = 3;

            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxNationalCode);
            this.Controls.Add(this.labelNationalCode);
            this.Name = "EntryForm";
            this.Text = "ورود";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        

        private Label labelNationalCode;
        private TextBox textBoxNationalCode;
        private Button buttonCheck;
        private Label labelInfo;

        #endregion
    }
}