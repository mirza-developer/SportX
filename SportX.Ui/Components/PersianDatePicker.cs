using System.Globalization;

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
        dateTextBox.Text = selectedDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    }

    private void PopulateCalendar()
    {
        calendarPanel.Controls.Clear();
        var headerLabel = new Label
        {
            Text = PersianMonthNames[persianCalendar.GetMonth(displayedMonth) - 1] + " " + persianCalendar.GetYear(displayedMonth),
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 30
        };
        calendarPanel.Controls.Add(headerLabel);

        var daysPanel = new Panel
        {
            Dock = DockStyle.Fill
        };
        calendarPanel.Controls.Add(daysPanel);

        string[] persianWeekDays = { "شنبه", "یک‌شنبه", "دو‌شنبه", "سه‌شنبه", "چهار‌شنبه", "پنج‌شنبه", "جمعه" };

        for (int i = 0; i < 7; i++)
        {
            var dayLabel = new Label
            {
                Text = persianWeekDays[i],
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Width = 28,
                Height = 20,
                BorderStyle = BorderStyle.FixedSingle
            };
            daysPanel.Controls.Add(dayLabel);
        }

        DateTime startDate = new DateTime(displayedMonth.Year, displayedMonth.Month, 1, persianCalendar);
        while (startDate.DayOfWeek != DayOfWeek.Saturday)
        {
            startDate = startDate.AddDays(-1);
        }

        for (int week = 0; week < 6; week++)
        {
            for (int day = 0; day < 7; day++)
            {
                DateTime currentDate = startDate.AddDays(week * 7 + day);
                Button dayButton = new Button
                {
                    Text = persianCalendar.GetDayOfMonth(currentDate).ToString(),
                    Width = 28,
                    Height = 28,
                    Tag = currentDate,
                    FlatStyle = FlatStyle.Flat,
                    Margin = new Padding(1)
                };

                if (currentDate.Month != displayedMonth.Month)
                {
                    dayButton.ForeColor = Color.Gray;
                }
                else if (currentDate.Date == selectedDate.Date)
                {
                    dayButton.BackColor = Color.Blue;
                    dayButton.ForeColor = Color.White;
                }

                dayButton.Click += DayButton_Click;
                daysPanel.Controls.Add(dayButton);
            }
        }
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
