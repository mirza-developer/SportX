using SportX.Ui.Models.Base;

namespace SportX.Ui.Models;
public class Plan : BaseModel
{
    public int PriceInTomans { get; set; }
    public string? Title { get; set; } 
    public int SessionCount { get; set; }
    public int? MembershipLengthInDays { get; set; }
    public MembershipType MembershipType { get; set; }
    public ICollection<Payment> Payments { get; set; }
}
