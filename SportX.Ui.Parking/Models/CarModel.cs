using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportX.Ui.Parking.Models;
public class CarModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [StringLength(512)]
    public string Name { get; set; }

    public int CompanyId { get; set; }
    public CarCompany CarCompany { get; set; }

    public ICollection<ParkingEnterance> Enterance { get; set; }
}
