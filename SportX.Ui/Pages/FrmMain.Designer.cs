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
            پرداختهاToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            groupBox2 = new GroupBox();
            dataGridViewAthletes = new DataGridView();
            menuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
            SuspendLayout();
            // 
            // labelNationalCode
            // 
            labelNationalCode.AutoSize = true;
            labelNationalCode.Location = new Point(470, 29);
            labelNationalCode.Name = "labelNationalCode";
            labelNationalCode.Size = new Size(87, 15);
            labelNationalCode.TabIndex = 1;
            labelNationalCode.Text = "کد ملی / شناسه";
            // 
            // textBoxNationalCode
            // 
            textBoxNationalCode.Location = new Point(114, 26);
            textBoxNationalCode.Name = "textBoxNationalCode";
            textBoxNationalCode.Size = new Size(331, 23);
            textBoxNationalCode.TabIndex = 2;
            // 
            // buttonCheck
            // 
            buttonCheck.BackColor = Color.ForestGreen;
            buttonCheck.Location = new Point(381, 72);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(66, 32);
            buttonCheck.TabIndex = 3;
            buttonCheck.Text = "ورود";
            buttonCheck.UseVisualStyleBackColor = false;
            buttonCheck.Click += ButtonCheck_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(237, 131);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 15);
            labelInfo.TabIndex = 4;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { signUpMenuItem, پرداختهاToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(596, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // signUpMenuItem
            // 
            signUpMenuItem.Name = "signUpMenuItem";
            signUpMenuItem.Size = new Size(55, 20);
            signUpMenuItem.Text = "ثبت نام";
            signUpMenuItem.Click += SignUpMenuItem_Click;
            // 
            // پرداختهاToolStripMenuItem
            // 
            پرداختهاToolStripMenuItem.Name = "پرداختهاToolStripMenuItem";
            پرداختهاToolStripMenuItem.Size = new Size(68, 20);
            پرداختهاToolStripMenuItem.Text = "پرداخت ها";
            پرداختهاToolStripMenuItem.Click += پرداختهاToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(textBoxNationalCode);
            groupBox1.Controls.Add(labelNationalCode);
            groupBox1.Controls.Add(buttonCheck);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 110);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "ثبت ورود";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(309, 72);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(66, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridViewAthletes);
            groupBox2.Location = new Point(0, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(596, 236);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "ورزشکاران وارد شده";
            // 
            // dataGridViewAthletes
            // 
            dataGridViewAthletes.Dock = DockStyle.Fill;
            dataGridViewAthletes.Location = new Point(3, 19);
            dataGridViewAthletes.MultiSelect = false;
            dataGridViewAthletes.Name = "dataGridViewAthletes";
            dataGridViewAthletes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAthletes.Size = new Size(590, 214);
            dataGridViewAthletes.TabIndex = 5;
            dataGridViewAthletes.SelectionChanged += dataGridViewAthletes_SelectionChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 376);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelInfo);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "FrmMain";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه اصلی";
            Load += FrmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelNationalCode;
        private TextBox textBoxNationalCode;
        private Button buttonCheck;
        private Label labelInfo;
        private MenuStrip menuStrip;
        private ToolStripMenuItem signUpMenuItem;
        private ToolStripMenuItem پرداختهاToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        #endregion

        private DataGridView dataGridViewAthletes;
        private Button btnExit;
    }
}