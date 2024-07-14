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
            calendarPanel.Location = new Point(0, 0);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(150, 150);
            calendarPanel.TabIndex = 2;
            // 
            // PersianDatePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dropdownButton);
            Controls.Add(dateTextBox);
            Controls.Add(calendarPanel);
            Name = "PersianDatePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox dateTextBox;
        private Button dropdownButton;
        private Panel calendarPanel;
        #endregion
    }
}
