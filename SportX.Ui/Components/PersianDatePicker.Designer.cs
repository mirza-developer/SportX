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
            calendarPanel = new Panel();
            headerPanel = new Panel();
            prevButton = new Button();
            headerLabel = new Label();
            nextButton = new Button();
            btnCell_0_0 = new Button();
            btnCell_0_1 = new Button();
            btnCell_0_2 = new Button();
            btnCell_0_3 = new Button();
            btnCell_0_4 = new Button();
            btnCell_0_5 = new Button();
            btnCell_0_6 = new Button();
            btnCell_1_0 = new Button();
            btnCell_1_1 = new Button();
            btnCell_1_2 = new Button();
            btnCell_1_3 = new Button();
            btnCell_1_4 = new Button();
            btnCell_1_5 = new Button();
            btnCell_1_6 = new Button();
            btnCell_2_0 = new Button();
            btnCell_2_1 = new Button();
            btnCell_2_2 = new Button();
            btnCell_2_3 = new Button();
            btnCell_2_4 = new Button();
            btnCell_2_5 = new Button();
            btnCell_2_6 = new Button();
            btnCell_3_0 = new Button();
            btnCell_3_1 = new Button();
            btnCell_3_2 = new Button();
            btnCell_3_3 = new Button();
            btnCell_3_4 = new Button();
            btnCell_3_5 = new Button();
            btnCell_3_6 = new Button();
            btnCell_4_0 = new Button();
            btnCell_4_1 = new Button();
            btnCell_4_2 = new Button();
            btnCell_4_3 = new Button();
            btnCell_4_4 = new Button();
            btnCell_4_5 = new Button();
            btnCell_4_6 = new Button();
            btnCell_5_0 = new Button();
            btnCell_5_1 = new Button();
            btnCell_5_2 = new Button();
            btnCell_5_3 = new Button();
            btnCell_5_4 = new Button();
            btnCell_5_5 = new Button();
            btnCell_5_6 = new Button();
            calendarPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(0, 0);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.ReadOnly = true;
            dateTextBox.Size = new Size(263, 23);
            dateTextBox.TabIndex = 0;
            dateTextBox.Click += DateTextBox_Click;
            // 
            // calendarPanel
            // 
            calendarPanel.Controls.Add(headerPanel);
            calendarPanel.Controls.Add(btnCell_0_0);
            calendarPanel.Controls.Add(btnCell_0_1);
            calendarPanel.Controls.Add(btnCell_0_2);
            calendarPanel.Controls.Add(btnCell_0_3);
            calendarPanel.Controls.Add(btnCell_0_4);
            calendarPanel.Controls.Add(btnCell_0_5);
            calendarPanel.Controls.Add(btnCell_0_6);
            calendarPanel.Controls.Add(btnCell_1_0);
            calendarPanel.Controls.Add(btnCell_1_1);
            calendarPanel.Controls.Add(btnCell_1_2);
            calendarPanel.Controls.Add(btnCell_1_3);
            calendarPanel.Controls.Add(btnCell_1_4);
            calendarPanel.Controls.Add(btnCell_1_5);
            calendarPanel.Controls.Add(btnCell_1_6);
            calendarPanel.Controls.Add(btnCell_2_0);
            calendarPanel.Controls.Add(btnCell_2_1);
            calendarPanel.Controls.Add(btnCell_2_2);
            calendarPanel.Controls.Add(btnCell_2_3);
            calendarPanel.Controls.Add(btnCell_2_4);
            calendarPanel.Controls.Add(btnCell_2_5);
            calendarPanel.Controls.Add(btnCell_2_6);
            calendarPanel.Controls.Add(btnCell_3_0);
            calendarPanel.Controls.Add(btnCell_3_1);
            calendarPanel.Controls.Add(btnCell_3_2);
            calendarPanel.Controls.Add(btnCell_3_3);
            calendarPanel.Controls.Add(btnCell_3_4);
            calendarPanel.Controls.Add(btnCell_3_5);
            calendarPanel.Controls.Add(btnCell_3_6);
            calendarPanel.Controls.Add(btnCell_4_0);
            calendarPanel.Controls.Add(btnCell_4_1);
            calendarPanel.Controls.Add(btnCell_4_2);
            calendarPanel.Controls.Add(btnCell_4_3);
            calendarPanel.Controls.Add(btnCell_4_4);
            calendarPanel.Controls.Add(btnCell_4_5);
            calendarPanel.Controls.Add(btnCell_4_6);
            calendarPanel.Controls.Add(btnCell_5_0);
            calendarPanel.Controls.Add(btnCell_5_1);
            calendarPanel.Controls.Add(btnCell_5_2);
            calendarPanel.Controls.Add(btnCell_5_3);
            calendarPanel.Controls.Add(btnCell_5_4);
            calendarPanel.Controls.Add(btnCell_5_5);
            calendarPanel.Controls.Add(btnCell_5_6);
            calendarPanel.Location = new Point(0, 30);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.Size = new Size(7, 36);
            calendarPanel.TabIndex = 2;
            calendarPanel.Visible = false;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(prevButton);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Controls.Add(nextButton);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(7, 36);
            headerPanel.TabIndex = 0;
            // 
            // prevButton
            // 
            prevButton.Dock = DockStyle.Right;
            prevButton.FlatStyle = FlatStyle.Flat;
            prevButton.Location = new Point(-25, 0);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(32, 36);
            prevButton.TabIndex = 0;
            prevButton.Text = "<";
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Location = new Point(32, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(0, 36);
            headerLabel.TabIndex = 2;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            nextButton.Dock = DockStyle.Left;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Location = new Point(0, 0);
            nextButton.Name = "nextButton";
            nextButton.RightToLeft = RightToLeft.Yes;
            nextButton.Size = new Size(32, 36);
            nextButton.TabIndex = 1;
            nextButton.Text = ">";
            // 
            // btnCell_0_0
            // 
            btnCell_0_0.FlatStyle = FlatStyle.Flat;
            btnCell_0_0.Location = new Point(0, 36);
            btnCell_0_0.Name = "btnCell_0_0";
            btnCell_0_0.Size = new Size(40, 32);
            btnCell_0_0.TabIndex = 10;
            // 
            // btnCell_0_1
            // 
            btnCell_0_1.FlatStyle = FlatStyle.Flat;
            btnCell_0_1.Location = new Point(0, 36);
            btnCell_0_1.Name = "btnCell_0_1";
            btnCell_0_1.Size = new Size(40, 32);
            btnCell_0_1.TabIndex = 10;
            // 
            // btnCell_0_2
            // 
            btnCell_0_2.FlatStyle = FlatStyle.Flat;
            btnCell_0_2.Location = new Point(0, 36);
            btnCell_0_2.Name = "btnCell_0_2";
            btnCell_0_2.Size = new Size(40, 32);
            btnCell_0_2.TabIndex = 10;
            // 
            // btnCell_0_3
            // 
            btnCell_0_3.FlatStyle = FlatStyle.Flat;
            btnCell_0_3.Location = new Point(0, 36);
            btnCell_0_3.Name = "btnCell_0_3";
            btnCell_0_3.Size = new Size(40, 32);
            btnCell_0_3.TabIndex = 10;
            // 
            // btnCell_0_4
            // 
            btnCell_0_4.FlatStyle = FlatStyle.Flat;
            btnCell_0_4.Location = new Point(0, 36);
            btnCell_0_4.Name = "btnCell_0_4";
            btnCell_0_4.Size = new Size(40, 32);
            btnCell_0_4.TabIndex = 10;
            // 
            // btnCell_0_5
            // 
            btnCell_0_5.FlatStyle = FlatStyle.Flat;
            btnCell_0_5.Location = new Point(0, 36);
            btnCell_0_5.Name = "btnCell_0_5";
            btnCell_0_5.Size = new Size(40, 32);
            btnCell_0_5.TabIndex = 10;
            // 
            // btnCell_0_6
            // 
            btnCell_0_6.FlatStyle = FlatStyle.Flat;
            btnCell_0_6.Location = new Point(0, 36);
            btnCell_0_6.Name = "btnCell_0_6";
            btnCell_0_6.Size = new Size(40, 32);
            btnCell_0_6.TabIndex = 10;
            // 
            // btnCell_1_0
            // 
            btnCell_1_0.FlatStyle = FlatStyle.Flat;
            btnCell_1_0.Location = new Point(0, 36);
            btnCell_1_0.Name = "btnCell_1_0";
            btnCell_1_0.Size = new Size(40, 32);
            btnCell_1_0.TabIndex = 10;
            // 
            // btnCell_1_1
            // 
            btnCell_1_1.FlatStyle = FlatStyle.Flat;
            btnCell_1_1.Location = new Point(0, 36);
            btnCell_1_1.Name = "btnCell_1_1";
            btnCell_1_1.Size = new Size(40, 32);
            btnCell_1_1.TabIndex = 10;
            // 
            // btnCell_1_2
            // 
            btnCell_1_2.FlatStyle = FlatStyle.Flat;
            btnCell_1_2.Location = new Point(0, 36);
            btnCell_1_2.Name = "btnCell_1_2";
            btnCell_1_2.Size = new Size(40, 32);
            btnCell_1_2.TabIndex = 10;
            // 
            // btnCell_1_3
            // 
            btnCell_1_3.FlatStyle = FlatStyle.Flat;
            btnCell_1_3.Location = new Point(0, 36);
            btnCell_1_3.Name = "btnCell_1_3";
            btnCell_1_3.Size = new Size(40, 32);
            btnCell_1_3.TabIndex = 10;
            // 
            // btnCell_1_4
            // 
            btnCell_1_4.FlatStyle = FlatStyle.Flat;
            btnCell_1_4.Location = new Point(0, 36);
            btnCell_1_4.Name = "btnCell_1_4";
            btnCell_1_4.Size = new Size(40, 32);
            btnCell_1_4.TabIndex = 10;
            // 
            // btnCell_1_5
            // 
            btnCell_1_5.FlatStyle = FlatStyle.Flat;
            btnCell_1_5.Location = new Point(0, 36);
            btnCell_1_5.Name = "btnCell_1_5";
            btnCell_1_5.Size = new Size(40, 32);
            btnCell_1_5.TabIndex = 10;
            // 
            // btnCell_1_6
            // 
            btnCell_1_6.FlatStyle = FlatStyle.Flat;
            btnCell_1_6.Location = new Point(0, 36);
            btnCell_1_6.Name = "btnCell_1_6";
            btnCell_1_6.Size = new Size(40, 32);
            btnCell_1_6.TabIndex = 10;
            // 
            // btnCell_2_0
            // 
            btnCell_2_0.FlatStyle = FlatStyle.Flat;
            btnCell_2_0.Location = new Point(0, 36);
            btnCell_2_0.Name = "btnCell_2_0";
            btnCell_2_0.Size = new Size(40, 32);
            btnCell_2_0.TabIndex = 10;
            // 
            // btnCell_2_1
            // 
            btnCell_2_1.FlatStyle = FlatStyle.Flat;
            btnCell_2_1.Location = new Point(0, 36);
            btnCell_2_1.Name = "btnCell_2_1";
            btnCell_2_1.Size = new Size(40, 32);
            btnCell_2_1.TabIndex = 10;
            // 
            // btnCell_2_2
            // 
            btnCell_2_2.FlatStyle = FlatStyle.Flat;
            btnCell_2_2.Location = new Point(0, 36);
            btnCell_2_2.Name = "btnCell_2_2";
            btnCell_2_2.Size = new Size(40, 32);
            btnCell_2_2.TabIndex = 10;
            // 
            // btnCell_2_3
            // 
            btnCell_2_3.FlatStyle = FlatStyle.Flat;
            btnCell_2_3.Location = new Point(0, 36);
            btnCell_2_3.Name = "btnCell_2_3";
            btnCell_2_3.Size = new Size(40, 32);
            btnCell_2_3.TabIndex = 10;
            // 
            // btnCell_2_4
            // 
            btnCell_2_4.FlatStyle = FlatStyle.Flat;
            btnCell_2_4.Location = new Point(0, 36);
            btnCell_2_4.Name = "btnCell_2_4";
            btnCell_2_4.Size = new Size(40, 32);
            btnCell_2_4.TabIndex = 10;
            // 
            // btnCell_2_5
            // 
            btnCell_2_5.FlatStyle = FlatStyle.Flat;
            btnCell_2_5.Location = new Point(0, 36);
            btnCell_2_5.Name = "btnCell_2_5";
            btnCell_2_5.Size = new Size(40, 32);
            btnCell_2_5.TabIndex = 10;
            // 
            // btnCell_2_6
            // 
            btnCell_2_6.FlatStyle = FlatStyle.Flat;
            btnCell_2_6.Location = new Point(0, 36);
            btnCell_2_6.Name = "btnCell_2_6";
            btnCell_2_6.Size = new Size(40, 32);
            btnCell_2_6.TabIndex = 10;
            // 
            // btnCell_3_0
            // 
            btnCell_3_0.FlatStyle = FlatStyle.Flat;
            btnCell_3_0.Location = new Point(0, 36);
            btnCell_3_0.Name = "btnCell_3_0";
            btnCell_3_0.Size = new Size(40, 32);
            btnCell_3_0.TabIndex = 10;
            // 
            // btnCell_3_1
            // 
            btnCell_3_1.FlatStyle = FlatStyle.Flat;
            btnCell_3_1.Location = new Point(0, 36);
            btnCell_3_1.Name = "btnCell_3_1";
            btnCell_3_1.Size = new Size(40, 32);
            btnCell_3_1.TabIndex = 10;
            // 
            // btnCell_3_2
            // 
            btnCell_3_2.FlatStyle = FlatStyle.Flat;
            btnCell_3_2.Location = new Point(0, 36);
            btnCell_3_2.Name = "btnCell_3_2";
            btnCell_3_2.Size = new Size(40, 32);
            btnCell_3_2.TabIndex = 10;
            // 
            // btnCell_3_3
            // 
            btnCell_3_3.FlatStyle = FlatStyle.Flat;
            btnCell_3_3.Location = new Point(0, 36);
            btnCell_3_3.Name = "btnCell_3_3";
            btnCell_3_3.Size = new Size(40, 32);
            btnCell_3_3.TabIndex = 10;
            // 
            // btnCell_3_4
            // 
            btnCell_3_4.FlatStyle = FlatStyle.Flat;
            btnCell_3_4.Location = new Point(0, 36);
            btnCell_3_4.Name = "btnCell_3_4";
            btnCell_3_4.Size = new Size(40, 32);
            btnCell_3_4.TabIndex = 10;
            // 
            // btnCell_3_5
            // 
            btnCell_3_5.FlatStyle = FlatStyle.Flat;
            btnCell_3_5.Location = new Point(0, 36);
            btnCell_3_5.Name = "btnCell_3_5";
            btnCell_3_5.Size = new Size(40, 32);
            btnCell_3_5.TabIndex = 10;
            // 
            // btnCell_3_6
            // 
            btnCell_3_6.FlatStyle = FlatStyle.Flat;
            btnCell_3_6.Location = new Point(0, 36);
            btnCell_3_6.Name = "btnCell_3_6";
            btnCell_3_6.Size = new Size(40, 32);
            btnCell_3_6.TabIndex = 10;
            // 
            // btnCell_4_0
            // 
            btnCell_4_0.FlatStyle = FlatStyle.Flat;
            btnCell_4_0.Location = new Point(0, 36);
            btnCell_4_0.Name = "btnCell_4_0";
            btnCell_4_0.Size = new Size(40, 32);
            btnCell_4_0.TabIndex = 10;
            // 
            // btnCell_4_1
            // 
            btnCell_4_1.FlatStyle = FlatStyle.Flat;
            btnCell_4_1.Location = new Point(0, 36);
            btnCell_4_1.Name = "btnCell_4_1";
            btnCell_4_1.Size = new Size(40, 32);
            btnCell_4_1.TabIndex = 10;
            // 
            // btnCell_4_2
            // 
            btnCell_4_2.FlatStyle = FlatStyle.Flat;
            btnCell_4_2.Location = new Point(0, 36);
            btnCell_4_2.Name = "btnCell_4_2";
            btnCell_4_2.Size = new Size(40, 32);
            btnCell_4_2.TabIndex = 10;
            // 
            // btnCell_4_3
            // 
            btnCell_4_3.FlatStyle = FlatStyle.Flat;
            btnCell_4_3.Location = new Point(0, 36);
            btnCell_4_3.Name = "btnCell_4_3";
            btnCell_4_3.Size = new Size(40, 32);
            btnCell_4_3.TabIndex = 10;
            // 
            // btnCell_4_4
            // 
            btnCell_4_4.FlatStyle = FlatStyle.Flat;
            btnCell_4_4.Location = new Point(0, 36);
            btnCell_4_4.Name = "btnCell_4_4";
            btnCell_4_4.Size = new Size(40, 32);
            btnCell_4_4.TabIndex = 10;
            // 
            // btnCell_4_5
            // 
            btnCell_4_5.FlatStyle = FlatStyle.Flat;
            btnCell_4_5.Location = new Point(0, 36);
            btnCell_4_5.Name = "btnCell_4_5";
            btnCell_4_5.Size = new Size(40, 32);
            btnCell_4_5.TabIndex = 10;
            // 
            // btnCell_4_6
            // 
            btnCell_4_6.FlatStyle = FlatStyle.Flat;
            btnCell_4_6.Location = new Point(0, 36);
            btnCell_4_6.Name = "btnCell_4_6";
            btnCell_4_6.Size = new Size(40, 32);
            btnCell_4_6.TabIndex = 10;
            // 
            // btnCell_5_0
            // 
            btnCell_5_0.FlatStyle = FlatStyle.Flat;
            btnCell_5_0.Location = new Point(0, 36);
            btnCell_5_0.Name = "btnCell_5_0";
            btnCell_5_0.Size = new Size(40, 32);
            btnCell_5_0.TabIndex = 10;
            // 
            // btnCell_5_1
            // 
            btnCell_5_1.FlatStyle = FlatStyle.Flat;
            btnCell_5_1.Location = new Point(0, 36);
            btnCell_5_1.Name = "btnCell_5_1";
            btnCell_5_1.Size = new Size(40, 32);
            btnCell_5_1.TabIndex = 10;
            // 
            // btnCell_5_2
            // 
            btnCell_5_2.FlatStyle = FlatStyle.Flat;
            btnCell_5_2.Location = new Point(0, 36);
            btnCell_5_2.Name = "btnCell_5_2";
            btnCell_5_2.Size = new Size(40, 32);
            btnCell_5_2.TabIndex = 10;
            // 
            // btnCell_5_3
            // 
            btnCell_5_3.FlatStyle = FlatStyle.Flat;
            btnCell_5_3.Location = new Point(0, 36);
            btnCell_5_3.Name = "btnCell_5_3";
            btnCell_5_3.Size = new Size(40, 32);
            btnCell_5_3.TabIndex = 10;
            // 
            // btnCell_5_4
            // 
            btnCell_5_4.FlatStyle = FlatStyle.Flat;
            btnCell_5_4.Location = new Point(0, 36);
            btnCell_5_4.Name = "btnCell_5_4";
            btnCell_5_4.Size = new Size(40, 32);
            btnCell_5_4.TabIndex = 10;
            // 
            // btnCell_5_5
            // 
            btnCell_5_5.FlatStyle = FlatStyle.Flat;
            btnCell_5_5.Location = new Point(0, 36);
            btnCell_5_5.Name = "btnCell_5_5";
            btnCell_5_5.Size = new Size(40, 32);
            btnCell_5_5.TabIndex = 10;
            // 
            // btnCell_5_6
            // 
            btnCell_5_6.FlatStyle = FlatStyle.Flat;
            btnCell_5_6.Location = new Point(0, 36);
            btnCell_5_6.Name = "btnCell_5_6";
            btnCell_5_6.Size = new Size(40, 32);
            btnCell_5_6.TabIndex = 10;
            // 
            // PersianDatePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTextBox);
            Controls.Add(calendarPanel);
            Name = "PersianDatePicker";
            Size = new Size(263, 200);
            calendarPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dateTextBox;
        private Panel calendarPanel;
        private Panel headerPanel;
        private Button prevButton;
        private Button nextButton;
        private Label headerLabel;
        private Button btnCell_0_0;
        private Button btnCell_0_1;
        private Button btnCell_0_2;
        private Button btnCell_0_3;
        private Button btnCell_0_4;
        private Button btnCell_0_5;
        private Button btnCell_0_6;
        private Button btnCell_1_0;
        private Button btnCell_1_1;
        private Button btnCell_1_2;
        private Button btnCell_1_3;
        private Button btnCell_1_4;
        private Button btnCell_1_5;
        private Button btnCell_1_6;
        private Button btnCell_2_0;
        private Button btnCell_2_1;
        private Button btnCell_2_2;
        private Button btnCell_2_3;
        private Button btnCell_2_4;
        private Button btnCell_2_5;
        private Button btnCell_2_6;
        private Button btnCell_3_0;
        private Button btnCell_3_1;
        private Button btnCell_3_2;
        private Button btnCell_3_3;
        private Button btnCell_3_4;
        private Button btnCell_3_5;
        private Button btnCell_3_6;
        private Button btnCell_4_0;
        private Button btnCell_4_1;
        private Button btnCell_4_2;
        private Button btnCell_4_3;
        private Button btnCell_4_4;
        private Button btnCell_4_5;
        private Button btnCell_4_6;
        private Button btnCell_5_0;
        private Button btnCell_5_1;
        private Button btnCell_5_2;
        private Button btnCell_5_3;
        private Button btnCell_5_4;
        private Button btnCell_5_5;
        private Button btnCell_5_6;
    }
}
