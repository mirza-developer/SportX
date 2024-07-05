using SportX.Ui.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace SportX.Ui.Models;
public class Athlete : BaseModel
{
    [Required]
    [StringLength(2000)]
    public string Name { get; set; }

    [StringLength(10)]
    public string? NationalCode { get; set; }

    [StringLength(20)]
    public string? Phone { get; set; }

    [Required]
    public bool IsMale { get; set; }

    [StringLength(10)]
    public string? DateOfBirth { get; set; }

    [StringLength(10)]
    public string? PaidUntilDate { get; set; }

    public MembershipType? Membership { get; set; }

    public ICollection<Payment> Payments { get; set; }
    public ICollection<AthleteUsageLog> Usages { get; set; }
}
