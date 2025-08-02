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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            labelInfo = new Label();
            menuStrip = new MenuStrip();
            signUpMenuItem = new ToolStripMenuItem();
            پرداختهاToolStripMenuItem = new ToolStripMenuItem();
            گزارشهاToolStripMenuItem = new ToolStripMenuItem();
            گزارشماهیانهپرداختToolStripMenuItem = new ToolStripMenuItem();
            گزارشحضورورزشکارToolStripMenuItem = new ToolStripMenuItem();
            تنظیماتToolStripMenuItem = new ToolStripMenuItem();
            مدیریتبرنامههاToolStripMenuItem = new ToolStripMenuItem();
            تهیهپشتیبانToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxSearch = new TextBox();
            label3 = new Label();
            buttonSearch = new Button();
            dataGridViewAthletes = new DataGridView();
            timerFocus = new System.Windows.Forms.Timer(components);
            timerClearInfo = new System.Windows.Forms.Timer(components);
            groupBoxInfo = new GroupBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            textBoxEpc = new TextBox();
            buttonEpc = new Button();
            textBoxStatus = new TextBox();
            label7 = new Label();
            textBoxEndDate = new TextBox();
            label6 = new Label();
            textboxRemainingSessions = new TextBox();
            label5 = new Label();
            textBoxAddress = new TextBox();
            label4 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxPhone = new TextBox();
            labelPhone = new Label();
            textBoxNationalCode = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBox1 = new TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            txtPlan = new TextBox();
            label9 = new Label();
            menuStrip.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
            groupBoxInfo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            menuStrip.Items.AddRange(new ToolStripItem[] { signUpMenuItem, پرداختهاToolStripMenuItem, گزارشهاToolStripMenuItem, تنظیماتToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(753, 24);
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
            // گزارشهاToolStripMenuItem
            // 
            گزارشهاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { گزارشماهیانهپرداختToolStripMenuItem, گزارشحضورورزشکارToolStripMenuItem });
            گزارشهاToolStripMenuItem.Name = "گزارشهاToolStripMenuItem";
            گزارشهاToolStripMenuItem.Size = new Size(64, 20);
            گزارشهاToolStripMenuItem.Text = "گزارش ها";
            // 
            // گزارشماهیانهپرداختToolStripMenuItem
            // 
            گزارشماهیانهپرداختToolStripMenuItem.Name = "گزارشماهیانهپرداختToolStripMenuItem";
            گزارشماهیانهپرداختToolStripMenuItem.Size = new Size(181, 22);
            گزارشماهیانهپرداختToolStripMenuItem.Text = "گزارش ماهیانه پرداخت";
            گزارشماهیانهپرداختToolStripMenuItem.Click += گزارشماهیانهپرداختToolStripMenuItem_Click;
            // 
            // گزارشحضورورزشکارToolStripMenuItem
            // 
            گزارشحضورورزشکارToolStripMenuItem.Name = "گزارشحضورورزشکارToolStripMenuItem";
            گزارشحضورورزشکارToolStripMenuItem.Size = new Size(181, 22);
            گزارشحضورورزشکارToolStripMenuItem.Text = "گزارش حضور ورزشکار";
            گزارشحضورورزشکارToolStripMenuItem.Click += گزارشحضورورزشکارToolStripMenuItem_Click;
            // 
            // تنظیماتToolStripMenuItem
            // 
            تنظیماتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { مدیریتبرنامههاToolStripMenuItem, تهیهپشتیبانToolStripMenuItem });
            تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            تنظیماتToolStripMenuItem.Size = new Size(62, 20);
            تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // مدیریتبرنامههاToolStripMenuItem
            // 
            مدیریتبرنامههاToolStripMenuItem.Name = "مدیریتبرنامههاToolStripMenuItem";
            مدیریتبرنامههاToolStripMenuItem.Size = new Size(157, 22);
            مدیریتبرنامههاToolStripMenuItem.Text = "مدیریت برنامه ها";
            مدیریتبرنامههاToolStripMenuItem.Click += مدیریتبرنامههاToolStripMenuItem_Click;
            // 
            // تهیهپشتیبانToolStripMenuItem
            // 
            تهیهپشتیبانToolStripMenuItem.Name = "تهیهپشتیبانToolStripMenuItem";
            تهیهپشتیبانToolStripMenuItem.Size = new Size(157, 22);
            تهیهپشتیبانToolStripMenuItem.Text = "تهیه پشتیبان";
            تهیهپشتیبانToolStripMenuItem.Click += تهیهپشتیبانToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dataGridViewAthletes);
            groupBox2.Location = new Point(0, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(753, 366);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "ورزشکاران وارد شده";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBoxSearch);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(buttonSearch);
            groupBox3.Location = new Point(6, 19);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(741, 57);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "جستجو";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(452, 26);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(176, 23);
            textBoxSearch.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(631, 29);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 23;
            label3.Text = "نام/کدملی/شناسه";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(392, 23);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(54, 26);
            buttonSearch.TabIndex = 22;
            buttonSearch.Text = "جستجو";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewAthletes
            // 
            dataGridViewAthletes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAthletes.ColumnHeadersHeight = 34;
            dataGridViewAthletes.Location = new Point(3, 82);
            dataGridViewAthletes.MultiSelect = false;
            dataGridViewAthletes.Name = "dataGridViewAthletes";
            dataGridViewAthletes.RowHeadersVisible = false;
            dataGridViewAthletes.RowHeadersWidth = 62;
            dataGridViewAthletes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAthletes.Size = new Size(748, 214);
            dataGridViewAthletes.TabIndex = 5;
            // 
            // timerFocus
            // 
            timerFocus.Interval = 500;
            timerFocus.Tick += timerFocus_Tick;
            // 
            // timerClearInfo
            // 
            timerClearInfo.Interval = 10000;
            timerClearInfo.Tick += timerClearInfo_Tick;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo.Controls.Add(txtPlan);
            groupBoxInfo.Controls.Add(label9);
            groupBoxInfo.Controls.Add(groupBox1);
            groupBoxInfo.Controls.Add(textBoxStatus);
            groupBoxInfo.Controls.Add(label7);
            groupBoxInfo.Controls.Add(textBoxEndDate);
            groupBoxInfo.Controls.Add(label6);
            groupBoxInfo.Controls.Add(textboxRemainingSessions);
            groupBoxInfo.Controls.Add(label5);
            groupBoxInfo.Controls.Add(textBoxAddress);
            groupBoxInfo.Controls.Add(label4);
            groupBoxInfo.Controls.Add(textBoxId);
            groupBoxInfo.Controls.Add(label2);
            groupBoxInfo.Controls.Add(textBoxPhone);
            groupBoxInfo.Controls.Add(labelPhone);
            groupBoxInfo.Controls.Add(textBoxNationalCode);
            groupBoxInfo.Controls.Add(label1);
            groupBoxInfo.Controls.Add(textBoxName);
            groupBoxInfo.Controls.Add(labelName);
            groupBoxInfo.Controls.Add(textBox1);
            groupBoxInfo.Location = new Point(6, 27);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(741, 201);
            groupBoxInfo.TabIndex = 30;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "اطلاعات ورزشکار";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxEpc);
            groupBox1.Controls.Add(buttonEpc);
            groupBox1.Location = new Point(6, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 50);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "ثبت ورود/خروج با کارت";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(651, 24);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 30;
            label8.Text = "شناسه کارت";
            // 
            // textBoxEpc
            // 
            textBoxEpc.Location = new Point(405, 21);
            textBoxEpc.Name = "textBoxEpc";
            textBoxEpc.ReadOnly = true;
            textBoxEpc.Size = new Size(240, 23);
            textBoxEpc.TabIndex = 29;
            textBoxEpc.KeyDown += textBoxEpc_KeyDown;
            // 
            // buttonEpc
            // 
            buttonEpc.Location = new Point(344, 18);
            buttonEpc.Name = "buttonEpc";
            buttonEpc.Size = new Size(55, 26);
            buttonEpc.TabIndex = 28;
            buttonEpc.Text = "قرائت";
            buttonEpc.UseVisualStyleBackColor = true;
            buttonEpc.Click += buttonEpc_Click;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(36, 90);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(133, 23);
            textBoxStatus.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(172, 93);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 44;
            label7.Text = "امکان ورود";
            // 
            // textBoxEndDate
            // 
            textBoxEndDate.Location = new Point(292, 90);
            textBoxEndDate.Name = "textBoxEndDate";
            textBoxEndDate.ReadOnly = true;
            textBoxEndDate.Size = new Size(133, 23);
            textBoxEndDate.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 93);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 42;
            label6.Text = "تاریخ اتمام";
            // 
            // textboxRemainingSessions
            // 
            textboxRemainingSessions.Location = new Point(495, 90);
            textboxRemainingSessions.Name = "textboxRemainingSessions";
            textboxRemainingSessions.ReadOnly = true;
            textboxRemainingSessions.Size = new Size(133, 23);
            textboxRemainingSessions.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 93);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 40;
            label5.Text = "جلسات باقی مانده";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(37, 57);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(419, 23);
            textBoxAddress.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 60);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 38;
            label4.Text = "آدرس";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(496, 25);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(133, 23);
            textBoxId.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(632, 28);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 36;
            label2.Text = "کد";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(37, 22);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(165, 23);
            textBoxPhone.TabIndex = 35;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(210, 25);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(29, 15);
            labelPhone.TabIndex = 34;
            labelPhone.Text = "تلفن";
            // 
            // textBoxNationalCode
            // 
            textBoxNationalCode.Location = new Point(496, 54);
            textBoxNationalCode.Name = "textBoxNationalCode";
            textBoxNationalCode.ReadOnly = true;
            textBoxNationalCode.Size = new Size(133, 23);
            textBoxNationalCode.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(632, 57);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 32;
            label1.Text = "کد ملی";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(240, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(216, 23);
            textBoxName.TabIndex = 31;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(459, 28);
            labelName.Name = "labelName";
            labelName.Size = new Size(21, 15);
            labelName.TabIndex = 30;
            labelName.Text = "نام";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1, 23);
            textBox1.TabIndex = 29;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(292, 120);
            txtPlan.Name = "txtPlan";
            txtPlan.ReadOnly = true;
            txtPlan.Size = new Size(336, 23);
            txtPlan.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(631, 123);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 47;
            label9.Text = "برنامه";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 529);
            Controls.Add(groupBoxInfo);
            Controls.Add(groupBox2);
            Controls.Add(labelInfo);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "FrmMain";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه اصلی";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelInfo;
        private MenuStrip menuStrip;
        private ToolStripMenuItem signUpMenuItem;
        private ToolStripMenuItem پرداختهاToolStripMenuItem;
        private GroupBox groupBox2;
        #endregion

        private DataGridView dataGridViewAthletes;
        private ToolStripMenuItem گزارشهاToolStripMenuItem;
        private ToolStripMenuItem گزارشماهیانهپرداختToolStripMenuItem;
        private ToolStripMenuItem گزارشحضورورزشکارToolStripMenuItem;
        private GroupBox groupBox3;
        private TextBox textBoxSearch;
        private Label label3;
        private Button buttonSearch;
        private System.Windows.Forms.Timer timerFocus;
        private System.Windows.Forms.Timer timerClearInfo;
        private GroupBox groupBoxInfo;
        private TextBox textBox1;
        private TextBox textBoxAddress;
        private Label label4;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private TextBox textBoxNationalCode;
        private Label label1;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textboxRemainingSessions;
        private Label label5;
        private TextBox textBoxStatus;
        private Label label7;
        private TextBox textBoxEndDate;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox textBoxEpc;
        private Button buttonEpc;
        private System.Windows.Forms.Timer timer2;
        private Label label8;
        private ToolStripMenuItem تنظیماتToolStripMenuItem;
        private ToolStripMenuItem مدیریتبرنامههاToolStripMenuItem;
        private ToolStripMenuItem تهیهپشتیبانToolStripMenuItem;
        private TextBox txtPlan;
        private Label label9;
    }
}