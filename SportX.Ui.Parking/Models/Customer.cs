using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportX.Ui.Parking.Models;
public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(1024)]
    public string? Name { get; set; }

    [Required]
    [StringLength(20)]
    public string PhoneNumber { get; set; }

    public CustomerUsageType? CustomerUsageType { get; set; }

    public ICollection<ParkingEnterance> ParkingEnterances { get; set; }
}

public enum CustomerUsageType
{
    Martial,
    Skate,
    Gym,
    Pool
}