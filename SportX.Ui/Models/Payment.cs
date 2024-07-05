using SportX.Ui.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace SportX.Ui.Models;
public class Payment : BaseModel
{
    public long PriceInTomans { get; set; }

    [Required]
    [StringLength(10)]
    public string PayDate { get; set; }

    [StringLength(2000)]
    public string? Description { get; set; }

    [StringLength(128)]
    public string? ReceiptNumber { get; set; }

    public PaymentType? PaymentType { get; set; }

    public int? AthleteId { get; set; }
    public Athlete? Athlete { get; set; }
}
