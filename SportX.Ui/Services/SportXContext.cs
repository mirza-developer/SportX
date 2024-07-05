using Microsoft.EntityFrameworkCore;
using SportX.Ui.Models;

namespace SportX.Ui.Services;
public class SportXContext : DbContext
{
    public SportXContext(DbContextOptions<SportXContext> context) : base(context)
    { }

    public DbSet<Athlete> Athletes { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<AthleteUsageLog> Usages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Athlete>()
                    .HasMany(p => p.Payments)
                    .WithOne(p => p.Athlete)
                    .HasForeignKey(p => p.AthleteId)
                    .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Athlete>()
                    .HasMany(p => p.Usages)
                    .WithOne(p => p.Athlete)
                    .HasForeignKey(p => p.AthleteId)
                    .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }
}
