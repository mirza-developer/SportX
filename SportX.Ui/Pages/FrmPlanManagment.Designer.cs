namespace SportX.Ui.Pages
{
    partial class FrmPlanManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanManagment));
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelSessionCount = new Label();
            textBoxSessionCount = new TextBox();
            labelMembershipLength = new Label();
            textBoxMembershipLength = new TextBox();
            labelMembershipType = new Label();
            comboBoxMembershipType = new ComboBox();
            buttonSave = new Button();
            btnClear = new Button();
            buttonRemove = new Button();
            dataGridViewPlans = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlans).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Location = new Point(650, 36);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(143, 38);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "عنوان";
            labelTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(222, 36);
            textBoxTitle.Margin = new Padding(4, 5, 4, 5);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(413, 31);
            textBoxTitle.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.Location = new Point(650, 95);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(143, 38);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "مبلغ (تومان)";
            labelPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(222, 95);
            textBoxPrice.Margin = new Padding(4, 5, 4, 5);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(413, 31);
            textBoxPrice.TabIndex = 3;
            // 
            // labelSessionCount
            // 
            labelSessionCount.Location = new Point(650, 153);
            labelSessionCount.Margin = new Padding(4, 0, 4, 0);
            labelSessionCount.Name = "labelSessionCount";
            labelSessionCount.Size = new Size(143, 38);
            labelSessionCount.TabIndex = 4;
            labelSessionCount.Text = "تعداد جلسات";
            labelSessionCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxSessionCount
            // 
            textBoxSessionCount.Location = new Point(222, 153);
            textBoxSessionCount.Margin = new Padding(4, 5, 4, 5);
            textBoxSessionCount.Name = "textBoxSessionCount";
            textBoxSessionCount.Size = new Size(413, 31);
            textBoxSessionCount.TabIndex = 5;
            // 
            // labelMembershipLength
            // 
            labelMembershipLength.Location = new Point(650, 211);
            labelMembershipLength.Margin = new Padding(4, 0, 4, 0);
            labelMembershipLength.Name = "labelMembershipLength";
            labelMembershipLength.Size = new Size(143, 38);
            labelMembershipLength.TabIndex = 6;
            labelMembershipLength.Text = "مدت اعتبار (روز)";
            labelMembershipLength.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxMembershipLength
            // 
            textBoxMembershipLength.Location = new Point(222, 211);
            textBoxMembershipLength.Margin = new Padding(4, 5, 4, 5);
            textBoxMembershipLength.Name = "textBoxMembershipLength";
            textBoxMembershipLength.Size = new Size(413, 31);
            textBoxMembershipLength.TabIndex = 7;
            // 
            // labelMembershipType
            // 
            labelMembershipType.Location = new Point(650, 270);
            labelMembershipType.Margin = new Padding(4, 0, 4, 0);
            labelMembershipType.Name = "labelMembershipType";
            labelMembershipType.Size = new Size(143, 38);
            labelMembershipType.TabIndex = 8;
            labelMembershipType.Text = "نوع عضویت";
            labelMembershipType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxMembershipType
            // 
            comboBoxMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMembershipType.Items.AddRange(new object[] { "عادی", "نظامی" });
            comboBoxMembershipType.Location = new Point(222, 270);
            comboBoxMembershipType.Margin = new Padding(4, 5, 4, 5);
            comboBoxMembershipType.Name = "comboBoxMembershipType";
            comboBoxMembershipType.Size = new Size(413, 33);
            comboBoxMembershipType.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(222, 336);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(129, 50);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "ذخیره";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(365, 336);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 50);
            btnClear.TabIndex = 11;
            btnClear.Text = "جدید";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemove.Location = new Point(508, 336);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(129, 50);
            buttonRemove.TabIndex = 99;
            buttonRemove.Text = "حذف";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // dataGridViewPlans
            // 
            dataGridViewPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlans.Location = new Point(13, 436);
            dataGridViewPlans.Margin = new Padding(4, 5, 4, 5);
            dataGridViewPlans.MultiSelect = false;
            dataGridViewPlans.Name = "dataGridViewPlans";
            dataGridViewPlans.RowHeadersVisible = false;
            dataGridViewPlans.RowHeadersWidth = 62;
            dataGridViewPlans.RowTemplate.Height = 25;
            dataGridViewPlans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlans.Size = new Size(839, 367);
            dataGridViewPlans.TabIndex = 12;
            dataGridViewPlans.CellClick += dataGridViewPlans_CellClick;
            // 
            // FrmPlanManagment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 817);
            Controls.Add(dataGridViewPlans);
            Controls.Add(buttonRemove);
            Controls.Add(btnClear);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxMembershipType);
            Controls.Add(labelMembershipType);
            Controls.Add(textBoxMembershipLength);
            Controls.Add(labelMembershipLength);
            Controls.Add(textBoxSessionCount);
            Controls.Add(labelSessionCount);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmPlanManagment";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مدیریت پلن ها";
            Load += FrmPlanManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelSessionCount;
        private System.Windows.Forms.TextBox textBoxSessionCount;
        private System.Windows.Forms.Label labelMembershipLength;
        private System.Windows.Forms.TextBox textBoxMembershipLength;
        private System.Windows.Forms.Label labelMembershipType;
        private System.Windows.Forms.ComboBox comboBoxMembershipType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridViewPlans;
    }
}
