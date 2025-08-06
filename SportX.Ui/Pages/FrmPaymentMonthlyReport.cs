using Microsoft.EntityFrameworkCore;
using SportX.Tools;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Data;
using System.Drawing.Printing;

namespace SportX.Ui.Pages;
public partial class FrmPaymentMonthlyReport : Form
{
    private SportXContext context = new();
    private Athlete selectedAthlete;
    private int currentRow = 0;
    private List<string[]> printData;
    private decimal totalAmount = 0; // Store the total amount for printing
    private bool isFirstPage = true; // Track if we're printing the first page

    public FrmPaymentMonthlyReport()
    {
        InitializeComponent();
        InitializePrintDocument();
    }

    private void InitializePrintDocument()
    {
        printDocument = new PrintDocument();
        printDocument.PrintPage += PrintDocument_PrintPage;
        printDocument.DefaultPageSettings.Landscape = true; // Landscape for better table display
    }

    private void ButtonChooseAthlete_Click(object sender, EventArgs e)
    {
        using FrmChooseAthlete frmChooseAthlete = new();

        if (frmChooseAthlete.ShowDialog() == DialogResult.OK)
        {
            selectedAthlete = frmChooseAthlete.SelectedAthlete;
            textBoxAthlete.Text = selectedAthlete.Name;
        }
    }

    private void ButtonGenerateReport_Click(object sender, EventArgs e)
    {
        int indexer = 1;

        var payments = context.Payments
            .Include(p => p.Athlete)
            .Include(p => p.Plan)
            .AsQueryable();

        // Filter by selected athlete (optional)
        if (selectedAthlete != null)
        {
            payments = payments.Where(p => p.AthleteId == selectedAthlete.Id);
        }

        payments = payments.OrderBy(p => p.PayDate);

        var paymentsList = payments.ToList();

        if (!string.IsNullOrEmpty(dateTimePickerFromDate.Text))
        {
            paymentsList = paymentsList.Where(p => PersianCalendarTools.PersianToGregorian(p.PayDate).Date >= PersianCalendarTools.PersianToGregorian(dateTimePickerFromDate.Text)).ToList();
        }

        if (!string.IsNullOrEmpty(dateTimePickerToDate.Text))
        {
            paymentsList = paymentsList.Where(p => PersianCalendarTools.PersianToGregorian(p.PayDate).Date <= PersianCalendarTools.PersianToGregorian(dateTimePickerToDate.Text)).ToList();
        }

        dataGridViewReport.DataSource = paymentsList.Select(p => new
        {
            ردیف = indexer++,
            p.PriceInTomans,
            p.PayDate,
            AthleteName = p.Athlete.Name,
            PlanTitle = p.Plan?.Title ?? "بدون پلن",
            p.Description,
            p.ReceiptNumber,
            p.SessionCountFor,
            p.DateEndMembership,
            PaymentType = p.PaymentTypeString
        }).ToList();

        // Set DataGridView column headers in Persian
        dataGridViewReport.Columns["PriceInTomans"].HeaderText = "مبلغ (تومان)";
        dataGridViewReport.Columns["PayDate"].HeaderText = "تاریخ پرداخت";
        dataGridViewReport.Columns["AthleteName"].HeaderText = "ورزشکار";
        dataGridViewReport.Columns["PlanTitle"].HeaderText = "پلن";
        dataGridViewReport.Columns["Description"].HeaderText = "توضیحات";
        dataGridViewReport.Columns["ReceiptNumber"].HeaderText = "شماره رسید";
        dataGridViewReport.Columns["SessionCountFor"].HeaderText = "تعداد جلسات";
        dataGridViewReport.Columns["DateEndMembership"].HeaderText = "تاریخ پایان عضویت";
        dataGridViewReport.Columns["PaymentType"].HeaderText = "نوع پرداخت";

        // Calculate the total sum of payments
        var totalPayments = paymentsList.Sum(p => p.PriceInTomans);
        totalAmount = totalPayments; // Store for printing
        labelTotalPayments.Text = $"جمع مبالغ پرداختی: {totalPayments} تومان";
    }

    private void ButtonPrint_Click(object sender, EventArgs e)
    {
        if (dataGridViewReport.DataSource == null || dataGridViewReport.Rows.Count == 0)
        {
            MessageBox.Show("برای چاپ، ابتدا گزارش را تولید کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        PrepareDataForPrinting();

        using PrintPreviewDialog printPreview = new PrintPreviewDialog();
        printPreview.Document = printDocument;
        printPreview.WindowState = FormWindowState.Maximized;
        printPreview.ShowDialog();
    }

    private void PrepareDataForPrinting()
    {
        printData = new List<string[]>();
        
        // Add headers
        var headers = new string[dataGridViewReport.Columns.Count];
        for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
        {
            headers[i] = dataGridViewReport.Columns[i].HeaderText;
        }
        printData.Add(headers);

        // Add data rows
        foreach (DataGridViewRow row in dataGridViewReport.Rows)
        {
            if (!row.IsNewRow)
            {
                var rowData = new string[dataGridViewReport.Columns.Count];
                for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
                {
                    rowData[i] = row.Cells[i].Value?.ToString() ?? "";
                }
                printData.Add(rowData);
            }
        }
        
        // Reset printing state
        currentRow = 0;
        isFirstPage = true;
    }

    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;
        Font headerFont = new Font("B Nazanin", 12, FontStyle.Bold);
        Font titleFont = new Font("B Nazanin", 16, FontStyle.Bold);
        Font totalFont = new Font("B Nazanin", 14, FontStyle.Bold);
        Font dataFont = new Font("B Nazanin", 10);
        Brush brush = Brushes.Black;
        Brush totalBrush = new SolidBrush(Color.DarkBlue);

        // Create RTL StringFormat for Persian text
        StringFormat rtlStringFormat = new StringFormat(StringFormat.GenericDefault);
        rtlStringFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
        rtlStringFormat.Alignment = StringAlignment.Near;
        rtlStringFormat.LineAlignment = StringAlignment.Center;

        // Center alignment for table cells and content
        StringFormat centerFormat = new StringFormat();
        centerFormat.Alignment = StringAlignment.Center;
        centerFormat.LineAlignment = StringAlignment.Center;
        centerFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

        float yPosition = 50;
        float pageMargin = 100; // Increased margin for better centering

        // Print title and date range ONLY on the first page
        if (isFirstPage)
        {
            // Print title (centered)
            string title = "گزارش پرداخت‌ها";
            if (selectedAthlete != null)
            {
                title += $" - {selectedAthlete.Name}";
            }
            
            RectangleF titleRect = new RectangleF(pageMargin, yPosition, e.MarginBounds.Width - pageMargin * 2, 30);
            g.DrawString(title, titleFont, brush, titleRect, centerFormat);
            yPosition += 40;

            // Print date range (centered)
            string dateRange = $"از تاریخ: {dateTimePickerFromDate.Text} تا تاریخ: {dateTimePickerToDate.Text}";
            RectangleF dateRect = new RectangleF(pageMargin, yPosition, e.MarginBounds.Width - pageMargin * 2, 20);
            g.DrawString(dateRange, dataFont, brush, dateRect, centerFormat);
            yPosition += 30;
        }
        
        // Calculate table dimensions for centering
        float totalTableWidth = e.MarginBounds.Width - pageMargin * 2;
        float[] columnWidths = new float[printData[0].Length];
        
        // Assign proportional widths based on content
        columnWidths[0] = totalTableWidth * 0.05f; // ردیف
        columnWidths[1] = totalTableWidth * 0.12f; // مبلغ
        columnWidths[2] = totalTableWidth * 0.10f; // تاریخ پرداخت
        columnWidths[3] = totalTableWidth * 0.15f; // ورزشکار
        columnWidths[4] = totalTableWidth * 0.12f; // پلن
        columnWidths[5] = totalTableWidth * 0.15f; // توضیحات
        columnWidths[6] = totalTableWidth * 0.10f; // شماره رسید
        columnWidths[7] = totalTableWidth * 0.08f; // تعداد جلسات
        columnWidths[8] = totalTableWidth * 0.10f; // تاریخ پایان
        columnWidths[9] = totalTableWidth * 0.08f; // نوع پرداخت

        // Calculate table start position for centering
        float actualTableWidth = columnWidths.Sum();
        float tableStartX = pageMargin + (totalTableWidth - actualTableWidth) / 2;

        // Print headers on EVERY page when starting data rows
        if (currentRow == 0 || (currentRow == 1 && !isFirstPage))
        {
            float headerY = yPosition;
            float xPosition = tableStartX + actualTableWidth; // Start from right of centered table
            
            // Print headers from right to left (RTL order)
            for (int i = 0; i < printData[0].Length; i++)
            {
                xPosition -= columnWidths[i];
                Rectangle headerRect = new Rectangle((int)xPosition, (int)headerY, (int)columnWidths[i], 30);
                g.FillRectangle(Brushes.LightGray, headerRect);
                g.DrawRectangle(Pens.Black, headerRect);
                
                // Use center format for headers
                g.DrawString(printData[0][i], headerFont, brush, headerRect, centerFormat);
            }
            yPosition += 30;
            currentRow = 1; // Move to data rows after headers
        }

        // Print data rows
        while (currentRow < printData.Count && yPosition + 40 < e.MarginBounds.Bottom) // Leave space for total
        {
            float xPosition = tableStartX + actualTableWidth; // Start from right of centered table
            
            // Print data from right to left (RTL order)
            for (int i = 0; i < printData[currentRow].Length; i++)
            {
                xPosition -= columnWidths[i];
                Rectangle cellRect = new Rectangle((int)xPosition, (int)yPosition, (int)columnWidths[i], 25);
                g.DrawRectangle(Pens.Black, cellRect);
                
                // Use appropriate format based on content type
                StringFormat cellFormat;
                if (i == 0 || i == 1 || i == 7) // Numbers (ردیف، مبلغ، تعداد جلسات)
                {
                    cellFormat = centerFormat; // Center align numbers
                }
                else
                {
                    // For text content, use RTL format with center alignment
                    cellFormat = new StringFormat();
                    cellFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    cellFormat.Alignment = StringAlignment.Center;
                    cellFormat.LineAlignment = StringAlignment.Center;
                }
                
                // Add padding to cell rectangle for better text positioning
                Rectangle paddedRect = new Rectangle(cellRect.X + 3, cellRect.Y, cellRect.Width - 6, cellRect.Height);
                g.DrawString(printData[currentRow][i], dataFont, brush, paddedRect, cellFormat);
                
                // Dispose the format if we created a new one
                if (cellFormat != centerFormat)
                {
                    cellFormat.Dispose();
                }
            }
            
            yPosition += 25;
            currentRow++;
        }

        // Print total at the bottom if we're on the last page
        if (currentRow >= printData.Count)
        {
            yPosition += 20;
            
            // Draw a separator line above total
            float lineStartX = tableStartX;
            float lineEndX = tableStartX + actualTableWidth;
            g.DrawLine(new Pen(Color.Black, 2), lineStartX, yPosition - 5, lineEndX, yPosition - 5);
            
            // Create total text
            string totalText = $"جمع کل مبالغ پرداختی: {totalAmount:N0} تومان";
            
            // Create a highlighted background for total
            SizeF totalSize = g.MeasureString(totalText, totalFont);
            float totalX = tableStartX + (actualTableWidth - totalSize.Width) / 2;
            Rectangle totalBgRect = new Rectangle((int)totalX - 10, (int)yPosition, (int)totalSize.Width + 20, (int)totalSize.Height + 10);
            g.FillRectangle(new SolidBrush(Color.LightYellow), totalBgRect);
            g.DrawRectangle(new Pen(Color.DarkBlue, 2), totalBgRect);
            
            // Print the total text centered
            RectangleF totalRect = new RectangleF(tableStartX, yPosition + 5, actualTableWidth, totalSize.Height);
            g.DrawString(totalText, totalFont, totalBrush, totalRect, centerFormat);
        }

        // Check if we need more pages
        e.HasMorePages = currentRow < printData.Count;
        
        // Mark that we're no longer on the first page
        if (e.HasMorePages)
        {
            isFirstPage = false;
        }

        // Dispose string formats and brushes
        rtlStringFormat.Dispose();
        centerFormat.Dispose();
        totalBrush.Dispose();
    }

    private void FrmPaymentMonthlyReport_Load(object sender, EventArgs e)
    {
        dateTimePickerFromDate.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now);

        dateTimePickerToDate.Text = PersianCalendarTools.GregorianToPersian(DateTime.Now);
    }
}
