using Microsoft.EntityFrameworkCore;
using VetClinicMS.Models;

namespace VetClinicMS.Classes;

public class DbMainContext : DbContext
{
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Procedure> Procedures { get; set; }
    public DbSet<VisitStatusLog> VisitStatusLogs { get; set; }
    public DbSet<Veterinarian> Veterinarians { get; set; }
    public DbSet<PetPassport> PetPassports { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={Environment.CurrentDirectory}/main.db;");
    }
    
}