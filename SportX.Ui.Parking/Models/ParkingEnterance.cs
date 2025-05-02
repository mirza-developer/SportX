using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportX.Ui.Parking.Models;
public class ParkingEnterance
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string FullPlateNumber { get; set; }

    public int? CarModelId { get; set; }
    public CarModel? CarModel { get; set; }

    public int? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    [Required]
    public DateTime EnterDateTime { get; set; }

    public DateTime? ExitDateTime { get; set; }
}
