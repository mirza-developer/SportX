using SportX.Ui.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportX.Ui.Models;
public class Payment : BaseModel
{
    [Required]
    public long PriceInTomans { get; set; }

    [Required]
    [StringLength(10)]
    public string PayDate { get; set; }

    [StringLength(2000)]
    public string? Description { get; set; }

    [StringLength(128)]
    public string? ReceiptNumber { get; set; }

    [Required]
    public int SessionCountFor { get; set; }

    [StringLength(10)]
    public string? DateEndMembership { get; set; }

    public PaymentType? PaymentType { get; set; }

    [NotMapped]
    public string? PaymentTypeString 
    {
        get => PaymentType switch
        {
            Models.PaymentType.CardToCard => "کارت به کارت",
            Models.PaymentType.Pos => "پوز",
            Models.PaymentType.Cash => "نقد",
            _ => "مشخص نشده"
        };
    }

    public int? AthleteId { get; set; }
    public Athlete? Athlete { get; set; }

    public int? PlanId { get; set; }
    public Plan? Plan { get; set; }
}
