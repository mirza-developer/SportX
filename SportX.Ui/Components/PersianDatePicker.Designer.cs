namespace SportX.Ui.Components
{
    partial class PersianDatePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTextBox = new TextBox();
            dropdownButton = new Button();
            calendarPanel = new Panel();
            headerPanel = new Panel();
            prevButton = new Button();
            nextButton = new Button();
            headerLabel = new Label();
            daysTable = new TableLayoutPanel();
            calendarPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(0, 0);
            dateTextBox.Margin = new Padding(4, 5, 4, 5);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(213, 31);
            dateTextBox.TabIndex = 0;
            // 
            // dropdownButton
            // 
            dropdownButton.Location = new Point(0, 0);
            dropdownButton.Margin = new Padding(4, 5, 4, 5);
            dropdownButton.Name = "dropdownButton";
            dropdownButton.Size = new Size(64, 38);
            dropdownButton.TabIndex = 1;
            dropdownButton.Click += DropdownButton_Click;
            // 
            // calendarPanel
            // 
            calendarPanel.Controls.Add(headerPanel);
            calendarPanel.Controls.Add(daysTable);
            calendarPanel.Location = new Point(0, 50);
            calendarPanel.Margin = new Padding(4, 5, 4, 5);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(300, 383);
            calendarPanel.TabIndex = 2;
            calendarPanel.Visible = false;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(prevButton);
            headerPanel.Controls.Add(nextButton);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(4, 5, 4, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(300, 60);
            headerPanel.TabIndex = 0;
            // 
            // prevButton
            // 
            prevButton.Dock = DockStyle.Left;
            prevButton.FlatStyle = FlatStyle.Flat;
            prevButton.Location = new Point(0, 0);
            prevButton.Margin = new Padding(4, 5, 4, 5);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(46, 60);
            prevButton.TabIndex = 0;
            prevButton.Text = "<";
            // 
            // nextButton
            // 
            nextButton.Dock = DockStyle.Right;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Location = new Point(254, 0);
            nextButton.Margin = new Padding(4, 5, 4, 5);
            nextButton.Name = "nextButton";
            nextButton.RightToLeft = RightToLeft.Yes;
            nextButton.Size = new Size(46, 60);
            nextButton.TabIndex = 1;
            nextButton.Text = ">";
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(0, 0);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(300, 60);
            headerLabel.TabIndex = 2;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daysTable
            // 
            daysTable.BackColor = Color.White;
            daysTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            daysTable.ColumnCount = 7;
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            daysTable.Dock = DockStyle.Fill;
            daysTable.Location = new Point(0, 0);
            daysTable.Margin = new Padding(4, 5, 4, 5);
            daysTable.Name = "daysTable";
            daysTable.RowCount = 7;
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            daysTable.Size = new Size(300, 383);
            daysTable.TabIndex = 1;
            // 
            // PersianDatePicker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dropdownButton);
            Controls.Add(dateTextBox);
            Controls.Add(calendarPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PersianDatePicker";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(300, 433);
            calendarPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox dateTextBox;
        private Button dropdownButton;
        private Panel calendarPanel;
        private Panel headerPanel;
        private Button prevButton;
        private Button nextButton;
        private Label headerLabel;
        private TableLayoutPanel daysTable;
        #endregion
    }
}
