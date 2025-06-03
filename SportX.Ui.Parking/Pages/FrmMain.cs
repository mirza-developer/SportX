using Microsoft.EntityFrameworkCore;
using SportX.Ui.Parking.Services;

namespace SportX.Ui.Parking.Pages;
public partial class FrmMain : Form
{
    private SportXParkingContext _context = new(new DbContextOptions<SportXParkingContext>());
    public FrmMain()
    {
        InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {

    }
}
