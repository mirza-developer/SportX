using Microsoft.EntityFrameworkCore;
using SportX.Ui.Models;
using SportX.Ui.Services;
using System.Data;
using System.Windows.Forms;

namespace SportX.Ui.Pages;
public partial class FrmPlanManagment : Form
{
    private SportXContext _context = new(new DbContextOptions<SportXContext>());
    private Plan selectedPlan;
    public FrmPlanManagment()
    {
        InitializeComponent();
        ClearForm();
        LoadPlanList();
    }

    private void LoadPlanList()
    {
        var plans = _context.Plans
            .OrderByDescending(p => p.Id)
            .Select(p => new
            {
                p.Id,
                p.Title,
                p.PriceInTomans,
                p.SessionCount,
                p.MembershipLengthInDays,
                MembershipType = p.MembershipType.ToString()
            })
            .ToList();
        dataGridViewPlans.DataSource = plans;
        dataGridViewPlans.Columns["Id"].Visible = false;
        dataGridViewPlans.Columns["Title"].HeaderText = "عنوان";
        dataGridViewPlans.Columns["PriceInTomans"].HeaderText = "مبلغ (تومان)";
        dataGridViewPlans.Columns["SessionCount"].HeaderText = "تعداد جلسات";
        dataGridViewPlans.Columns["MembershipLengthInDays"].HeaderText = "مدت اعتبار (روز)";
        dataGridViewPlans.Columns["MembershipType"].HeaderText = "نوع عضویت";
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxTitle.Text) || string.IsNullOrWhiteSpace(textBoxPrice.Text) || string.IsNullOrWhiteSpace(textBoxSessionCount.Text))
        {
            MessageBox.Show("لطفا تمام فیلدهای ضروری را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (selectedPlan == null)
        {
            var newPlan = new Plan
            {
                Title = textBoxTitle.Text,
                PriceInTomans = int.Parse(textBoxPrice.Text),
                SessionCount = int.Parse(textBoxSessionCount.Text),
                MembershipLengthInDays = string.IsNullOrWhiteSpace(textBoxMembershipLength.Text) ? null : int.Parse(textBoxMembershipLength.Text),
                MembershipType = (MembershipType)comboBoxMembershipType.SelectedIndex,
                CreateDatetime = DateTime.Now
            };
            _context.Plans.Add(newPlan);
        }
        else
        {
            selectedPlan.Title = textBoxTitle.Text;
            selectedPlan.PriceInTomans = int.Parse(textBoxPrice.Text);
            selectedPlan.SessionCount = int.Parse(textBoxSessionCount.Text);
            selectedPlan.MembershipLengthInDays = string.IsNullOrWhiteSpace(textBoxMembershipLength.Text) ? null : int.Parse(textBoxMembershipLength.Text);
            selectedPlan.MembershipType = (MembershipType)comboBoxMembershipType.SelectedIndex;
            selectedPlan.LastModifyDatetime = DateTime.Now;
            _context.Update(selectedPlan);
        }
        _context.SaveChanges();
        MessageBox.Show("پلن ذخیره شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ClearForm();
        LoadPlanList();
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
        if (selectedPlan == null)
        {
            MessageBox.Show("لطفا یک پلن را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show("آیا از حذف این پلن مطمئن هستید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            _context.Plans.Remove(selectedPlan);
            _context.SaveChanges();
            MessageBox.Show("پلن حذف شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadPlanList();
        }
    }

    private void dataGridViewPlans_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            var id = (int)dataGridViewPlans.Rows[e.RowIndex].Cells["Id"].Value;
            selectedPlan = _context.Plans.FirstOrDefault(p => p.Id == id);
            if (selectedPlan != null)
            {
                textBoxTitle.Text = selectedPlan.Title;
                textBoxPrice.Text = selectedPlan.PriceInTomans.ToString();
                textBoxSessionCount.Text = selectedPlan.SessionCount.ToString();
                textBoxMembershipLength.Text = selectedPlan.MembershipLengthInDays?.ToString() ?? "";
                comboBoxMembershipType.SelectedIndex = (int)selectedPlan.MembershipType;
            }
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void ClearForm()
    {
        textBoxTitle.Clear();
        textBoxPrice.Clear();
        textBoxSessionCount.Clear();
        textBoxMembershipLength.Clear();
        comboBoxMembershipType.SelectedIndex = -1;
        selectedPlan = null;
    }

    private void FrmPlanManagment_Load(object sender, EventArgs e)
    {

    }
}
