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
        dateTextBox.Text = PersianCalendarTools.GregorianToPersian(selectedDate);
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
            Dock = DockStyle.Left,
            FlatStyle = FlatStyle.Flat
        };
        prevButton.Click += (s, e) => PreviousMonth();
        var nextButton = new Button
        {
            Text = ">",
            Width = 32,
            Height = 32,
            Dock = DockStyle.Right,
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

        // Calendar grid
        var daysTable = new TableLayoutPanel
        {
            RowCount = 7,
            ColumnCount = 7,
            Dock = DockStyle.Fill,
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
            BackColor = Color.White
        };
        daysTable.ColumnStyles.Clear();
        for (int i = 0; i < 7; i++)
            daysTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
        daysTable.RowStyles.Clear();
        for (int i = 0; i < 7; i++)
            daysTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));

        string[] persianWeekDays = { "شنبه", "یک‌شنبه", "دو‌شنبه", "سه‌شنبه", "چهار‌شنبه", "پنج‌شنبه", "جمعه" };
        for (int i = 0; i < 7; i++)
        {
            var dayLabel = new Label
            {
                Text = persianWeekDays[i],
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font(Font, FontStyle.Bold),
                BackColor = Color.LightGray
            };
            daysTable.Controls.Add(dayLabel, i, 0);
        }

        DateTime startDate = new DateTime(displayedMonth.Year, displayedMonth.Month, 1, persianCalendar);
        while (startDate.DayOfWeek != DayOfWeek.Saturday)
            startDate = startDate.AddDays(-1);

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
                    BackColor = Color.White
                };
                if (currentDate.Month != displayedMonth.Month)
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
                    dayButton.BackColor = Color.LightSkyBlue;
                }
                dayButton.Click += DayButton_Click;
                daysTable.Controls.Add(dayButton, day, week + 1);
            }
        }
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
