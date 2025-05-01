using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SportX.Ui.Parking.Models;

namespace SportX.Ui.Parking.Services;
public class SportXParkingContext : DbContext
{
    public SportXParkingContext()
    { }

    public SportXParkingContext(DbContextOptions<SportXParkingContext> context) : base(context)
    { }

    public DbSet<CarCompany> CarCompanies { get; set; }
    public DbSet<CarModel> CarModels { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ParkingEnterance> ParkingEnterances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarCompany>()
                    .HasMany(c => c.CarModels)
                    .WithOne(m => m.CarCompany)
                    .HasForeignKey(m => m.CompanyId)
                    .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CarModel>()
                    .HasMany(m => m.Enterance)
                    .WithOne(e => e.CarModel)
                    .HasForeignKey(e => e.CarModelId)
                    .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Customer>()
                    .HasMany(c => c.ParkingEnterances)
                    .WithOne(e => e.Customer)
                    .HasForeignKey(e => e.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(Program.Configuration.GetConnectionString("SqlDefaultConnectionString"));
        }
    }
}
