namespace SportX.Ui.Pages
{
    partial class FrmChooseAthlete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChooseAthlete));
            textBoxAthleteId = new TextBox();
            textBoxNationalCode = new TextBox();
            textBoxName = new TextBox();
            buttonSearch = new Button();
            dataGridViewAthletes = new DataGridView();
            buttonSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).BeginInit();
            SuspendLayout();
            // 
            // textBoxAthleteId
            // 
            textBoxAthleteId.Location = new Point(254, 20);
            textBoxAthleteId.Name = "textBoxAthleteId";
            textBoxAthleteId.PlaceholderText = "شناسه ورزشکار";
            textBoxAthleteId.Size = new Size(86, 23);
            textBoxAthleteId.TabIndex = 2;
            // 
            // textBoxNationalCode
            // 
            textBoxNationalCode.Location = new Point(346, 20);
            textBoxNationalCode.Name = "textBoxNationalCode";
            textBoxNationalCode.PlaceholderText = "کد ملی";
            textBoxNationalCode.Size = new Size(140, 23);
            textBoxNationalCode.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(492, 20);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "نام";
            textBoxName.Size = new Size(274, 23);
            textBoxName.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(148, 18);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 25);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "جستجو";
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // dataGridViewAthletes
            // 
            dataGridViewAthletes.Location = new Point(9, 62);
            dataGridViewAthletes.MultiSelect = false;
            dataGridViewAthletes.Name = "dataGridViewAthletes";
            dataGridViewAthletes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAthletes.Size = new Size(781, 337);
            dataGridViewAthletes.TabIndex = 4;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(42, 18);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(100, 25);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = "انتخاب";
            buttonSelect.Click += ButtonSelect_Click;
            // 
            // FrmChooseAthlete
            // 
            ClientSize = new Size(800, 411);
            Controls.Add(textBoxAthleteId);
            Controls.Add(textBoxNationalCode);
            Controls.Add(textBoxName);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridViewAthletes);
            Controls.Add(buttonSelect);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmChooseAthlete";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "انتخاب ورزشکار";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAthletes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxAthleteId;
        private TextBox textBoxNationalCode;
        private TextBox textBoxName;
        private Button buttonSearch;
        private DataGridView dataGridViewAthletes;
        private Button buttonSelect;
        #endregion
    }
}