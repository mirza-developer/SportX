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
            SuspendLayout();
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(0, 0);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(150, 23);
            dateTextBox.TabIndex = 0;
            // 
            // dropdownButton
            // 
            dropdownButton.Location = new Point(0, 0);
            dropdownButton.Name = "dropdownButton";
            dropdownButton.Size = new Size(45, 23);
            dropdownButton.TabIndex = 1;
            dropdownButton.Click += DropdownButton_Click;
            // 
            // calendarPanel
            // 
            calendarPanel.Location = new Point(0, 30);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(210, 230);
            calendarPanel.TabIndex = 2;
            calendarPanel.Visible = false;
            calendarPanel.Controls.Add(headerPanel);
            calendarPanel.Controls.Add(daysTable);
            // 
            // headerPanel
            // 
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 36;
            headerPanel.Controls.Add(prevButton);
            headerPanel.Controls.Add(nextButton);
            headerPanel.Controls.Add(headerLabel);
            // 
            // prevButton
            // 
            prevButton.Text = "<";
            prevButton.Width = 32;
            prevButton.Height = 32;
            prevButton.Dock = DockStyle.Left;
            prevButton.FlatStyle = FlatStyle.Flat;
            // 
            // nextButton
            // 
            nextButton.Text = ">";
            nextButton.Width = 32;
            nextButton.Height = 32;
            nextButton.Dock = DockStyle.Right;
            nextButton.FlatStyle = FlatStyle.Flat;
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            headerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // daysTable
            // 
            daysTable.Dock = DockStyle.Fill;
            daysTable.RowCount = 7;
            daysTable.ColumnCount = 7;
            daysTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            daysTable.BackColor = Color.White;
        
            // 
            // PersianDatePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dropdownButton);
            Controls.Add(dateTextBox);
            Controls.Add(calendarPanel);
            Name = "PersianDatePicker";
            Size = new Size(210, 260);
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
