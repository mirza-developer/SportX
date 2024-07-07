using SportX.Ui.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

    [Required]
    public int RemainingSessionCounts { get; set; }

    public MembershipType? Membership { get; set; }

    [NotMapped]
    public string? MembershipString 
    {
        get => Membership == MembershipType.Normal ? "معمولی" : "نظامی";
    }

    [NotMapped]
    public string? GenderString
    {
        get => IsMale ? "مرد" : "زن";
    }


    public ICollection<Payment> Payments { get; set; }
    public ICollection<AthleteUsageLog> Usages { get; set; }
}
