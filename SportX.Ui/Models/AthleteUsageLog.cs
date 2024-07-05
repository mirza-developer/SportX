using SportX.Ui.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace SportX.Ui.Models;
public class AthleteUsageLog : BaseModel
{
    [Required]
    public int AthleteId { get; set; }
    public Athlete Athlete { get; set; }

    [Required]
    public bool IsEntered { get; set; }

    [Required]
    public bool IsPaid { get; set; }
}
