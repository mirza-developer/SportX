using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SportX.Ui.Models;
using Microsoft.Data.SqlClient;

namespace SportX.Ui.Services;
public class SportXContext: DbContext
{
    public SportXContext()
    { }

    public SportXContext(DbContextOptions<SportXContext> context) : base(context)
    { }

    public DbSet<Athlete> Athletes { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<AthleteUsageLog> Usages { get; set; }
    public DbSet<Plan> Plans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Athlete>()
                    .HasMany(p => p.Payments)
                    .WithOne(p => p.Athlete)
                    .HasForeignKey(p => p.AthleteId)
                    .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Plan>()
                    .HasMany(p => p.Payments)
                    .WithOne(p => p.Plan)
                    .HasForeignKey(p => p.PlanId)
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

    public async Task<bool> CreateBackupAsync(string backupPath)
    {
        try
        {
            var connectionString = Program.Configuration.GetConnectionString("SqlDefaultConnectionString");
            var connectionBuilder = new SqlConnectionStringBuilder(connectionString);
            var databaseName = connectionBuilder.InitialCatalog;

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            var backupCommand = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupPath}' WITH FORMAT, INIT";
            using var command = new SqlCommand(backupCommand, connection);
            command.CommandTimeout = 300; 

            await command.ExecuteNonQueryAsync();
            return true;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Backup error: {ex.Message}");
            return false;
        }
    }
}
