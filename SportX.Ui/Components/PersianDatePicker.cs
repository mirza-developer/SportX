using System.Globalization;
using SportX.Tools;

namespace SportX.Ui.Components;

public partial class PersianDatePicker : UserControl
{
    private PersianCalendar persianCalendar;
    private DateTime selectedDate;
    private DateTime displayedMonth;
    private static readonly string[] PersianMonthNames =
    {
        "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور",
        "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"
    };

    public PersianDatePicker()
    {
        InitializeComponent();
        for (int i = 0; i < 7; i++)
        {
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));
        }
        InitializeCustomComponents();
    }

    private void InitializeCustomComponents()
    {
        persianCalendar = new PersianCalendar();
        selectedDate = DateTime.Today;
        displayedMonth = DateTime.Today;
        UpdateDateTextBox();
        PopulateCalendar();
    }

    private void DropdownButton_Click(object sender, EventArgs e)
    {
        calendarPanel.Visible = !calendarPanel.Visible;
    }

    private void UpdateDateTextBox()
    {
        int year = persianCalendar.GetYear(selectedDate);
        int month = persianCalendar.GetMonth(selectedDate);
        int day = persianCalendar.GetDayOfMonth(selectedDate);
        dateTextBox.Text = $"{year:0000}/{month:00}/{day:00}";
    }

    private void PopulateCalendar()
    {
        calendarPanel.Controls.Clear();

        // Header panel with navigation
        var headerPanel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 36
        };
        var prevButton = new Button
        {
            Text = "<",
            Width = 32,
            Height = 32,
            Dock = DockStyle.Right,
            FlatStyle = FlatStyle.Flat
        };
        prevButton.Click += (s, e) => PreviousMonth();
        var nextButton = new Button
        {
            Text = ">",
            Width = 32,
            Height = 32,
            Dock = DockStyle.Left,
            FlatStyle = FlatStyle.Flat
        };
        nextButton.Click += (s, e) => NextMonth();
        var headerLabel = new Label
        {
            Text = PersianMonthNames[persianCalendar.GetMonth(displayedMonth) - 1] + " " + persianCalendar.GetYear(displayedMonth),
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill,
            Font = new Font(Font, FontStyle.Bold),
            Height = 32
        };
        headerPanel.Controls.Add(prevButton); 
        headerPanel.Controls.Add(nextButton); 
        headerPanel.Controls.Add(headerLabel);
        calendarPanel.Controls.Add(headerPanel);

        int cellWidth = 54;
        int cellHeight = 36;
        var daysTable = new TableLayoutPanel
        {
            RowCount = 7,
            ColumnCount = 7,
            Location = new Point(0, headerPanel.Height),
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            BackColor = Color.White,
            Width = 7 * cellWidth,
            Height = 7 * cellHeight,
            AutoSize = false,
            Dock = DockStyle.None
        };
        daysTable.ColumnStyles.Clear();
        for (int i = 0; i < 7; i++)
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth));
        daysTable.RowStyles.Clear();
        for (int i = 0; i < 7; i++)
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, cellHeight));

        string[] persianWeekDays = { "شنبه", "یک‌شنبه", "دو‌شنبه", "سه‌شنبه", "چهار‌شنبه", "پنج‌شنبه", "جمعه" };
        for (int i = 0; i < 7; i++)
        {
            var dayLabel = new Label
            {
                Text = persianWeekDays[i],
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font(Font.FontFamily, 5, FontStyle.Regular), // even smaller font size
                BackColor = Color.LightGray
            };
            daysTable.Controls.Add(dayLabel, i, 0);
        }

        DateTime firstOfMonth = persianCalendar.ToDateTime(
            persianCalendar.GetYear(displayedMonth),
            persianCalendar.GetMonth(displayedMonth),
            1, 0, 0, 0, 0);
        // Find the first Saturday before or on the first of the Persian month
        int offset = ((int)firstOfMonth.DayOfWeek + 1) % 7; // Saturday=0 in Persian calendar
        DateTime startDate = firstOfMonth.AddDays(-offset);

        for (int week = 0; week < 6; week++)
        {
            for (int day = 0; day < 7; day++)
            {
                DateTime currentDate = startDate.AddDays(week * 7 + day);
                Button dayButton = new Button
                {
                    Text = persianCalendar.GetDayOfMonth(currentDate).ToString(),
                    Dock = DockStyle.Fill,
                    Tag = currentDate,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(0),
                    BackColor = Color.White,
                    Font = new Font(Font.FontFamily, 9, FontStyle.Regular)
                };
                if (persianCalendar.GetMonth(currentDate) != persianCalendar.GetMonth(displayedMonth) ||
                    persianCalendar.GetYear(currentDate) != persianCalendar.GetYear(displayedMonth))
                {
                    dayButton.ForeColor = Color.Gray;
                }
                else if (currentDate.Date == selectedDate.Date)
                {
                    dayButton.BackColor = Color.DodgerBlue;
                    dayButton.ForeColor = Color.White;
                    dayButton.Font = new Font(dayButton.Font, FontStyle.Bold);
                }
                else if (currentDate.Date == DateTime.Today.Date)
                {
                    dayButton.BackColor = Color.DarkOrange;
                    dayButton.ForeColor = Color.White;
                }
                dayButton.Click += DayButton_Click;
                daysTable.Controls.Add(dayButton, day, week + 1);
            }
        }
        calendarPanel.Width = daysTable.Width;
        calendarPanel.Height = headerPanel.Height + daysTable.Height;
        calendarPanel.Controls.Add(daysTable);
    }

    private void DayButton_Click(object sender, EventArgs e)
    {
        Button dayButton = sender as Button;
        selectedDate = (DateTime)dayButton.Tag;
        UpdateDateTextBox();
        calendarPanel.Visible = false;
    }

    private void PreviousMonth()
    {
        displayedMonth = persianCalendar.AddMonths(displayedMonth, -1);
        PopulateCalendar();
    }

    private void NextMonth()
    {
        displayedMonth = persianCalendar.AddMonths(displayedMonth, 1);
        PopulateCalendar();
    }
}
