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

    private Button[,] calendarButtons = new Button[6, 7];

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

        // Initialize calendarButtons array and wire up events
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                var btn = (Button)this.GetType().GetField($"btnCell_{i}_{j}", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(this);
                calendarButtons[i, j] = btn;
                btn.Click += DayButton_Click;
            }
        }

        // Wire up previous/next month buttons
        prevButton.Click += (s, e) => PreviousMonth();
        nextButton.Click += (s, e) => NextMonth();

        PopulateCalendar();
    }

    private void DropdownButton_Click(object sender, EventArgs e)
    {
        calendarPanel.Visible = !calendarPanel.Visible;
    }

    private void DateTextBox_Click(object sender, EventArgs e)
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
        DateTime firstOfMonth = persianCalendar.ToDateTime(
            persianCalendar.GetYear(displayedMonth),
            persianCalendar.GetMonth(displayedMonth),
            1, 0, 0, 0, 0);
        int offset = ((int)firstOfMonth.DayOfWeek + 1) % 7;
        DateTime startDate = firstOfMonth.AddDays(-offset);
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                var btn = calendarButtons[i, j];
                DateTime currentDate = startDate.AddDays(i * 7 + j);
                int currentMonth = persianCalendar.GetMonth(currentDate);
                int currentYear = persianCalendar.GetYear(currentDate);
                int displayedMonthNum = persianCalendar.GetMonth(displayedMonth);
                int displayedYearNum = persianCalendar.GetYear(displayedMonth);
                btn.Tag = currentDate;
                btn.Enabled = (currentMonth == displayedMonthNum && currentYear == displayedYearNum);
                btn.Text = persianCalendar.GetDayOfMonth(currentDate).ToString();
                btn.BackColor = Color.White;
                btn.Font = new Font(Font.FontFamily, 9, FontStyle.Regular);
                if (!btn.Enabled)
                {
                    btn.ForeColor = Color.Gray;
                }
                else if (currentDate.Date == selectedDate.Date)
                {
                    btn.BackColor = Color.DodgerBlue;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                }
                else if (currentDate.Date == DateTime.Today.Date)
                {
                    btn.BackColor = Color.DarkOrange;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.ForeColor = Color.Black;
                }
            }
        }
    }

    private void DayButton_Click(object sender, EventArgs e)
    {
        Button dayButton = sender as Button;
        selectedDate = (DateTime)dayButton.Tag;
        UpdateDateTextBox();
        calendarPanel.Visible = false;

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                var btn = calendarButtons[i, j];
                if (btn.Enabled)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font(Font.FontFamily, 9, FontStyle.Regular);
                }
                
                if ((DateTime)btn.Tag == selectedDate.Date)
                {
                    btn.BackColor = Color.DodgerBlue;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                }
                else if ((DateTime)btn.Tag == DateTime.Today.Date)
                {
                    btn.BackColor = Color.DarkOrange;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.ForeColor = Color.Black;
                }
            }
        }
        dayButton.BackColor = Color.DodgerBlue;
        dayButton.ForeColor = Color.White;
        dayButton.Font = new Font(dayButton.Font, FontStyle.Bold);
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
