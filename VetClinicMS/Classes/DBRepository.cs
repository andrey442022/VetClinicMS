using Microsoft.EntityFrameworkCore;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Classes;

public class DbRepository : IRepository, IDisposable, IAsyncDisposable
{
    private readonly DbMainContext dbContext = new();

    public DbRepository()
    {
        dbContext.Database.EnsureCreated();
        dbContext.Database.ExecuteSql($"PRAGMA journal_mode = WLA");
    }

    public async ValueTask DisposeAsync()
    {
        await dbContext.DisposeAsync();
    }

    public void Dispose()
    {
        dbContext.Dispose();
    }

    public Guid AddVisit(Visit visit)
    {
        dbContext.Visits.Add(visit);
        dbContext.SaveChanges();
        return visit.Id;
    }

    public List<Visit> GetVisits()
    {
        return dbContext.Visits.ToList();
    }

    public List<Visit> GetVisits(Func<Visit, bool> prediction)
    {
        return dbContext.Visits
            .Include(item => item.Procedures)
            .Include(item => item.Veterinarian)
            .Include(item => item.Patient)
            .Include(item => item.Patient.Owner)
            .Where(prediction).ToList();
    }

    public Visit? GetVisit(Guid id)
    {
        return dbContext.Visits
            .Include(item => item.Procedures)
            .Include(item => item.Veterinarian)
            .Include(item => item.Patient)
            .Include(item => item.Patient.Owner)
            .FirstOrDefault(v => v.Id == id);
    }

    public void UpdateVisit(Visit visit)
    {
        dbContext.Visits.Update(visit);
        dbContext.SaveChanges();
    }

    public Guid AddPet(Pet pet)
    {
        dbContext.Pets.Add(pet);
        dbContext.SaveChanges();
        return pet.Id;
    }

    public List<Pet> GetPets()
    {
        return dbContext.Pets.ToList();
    }

    public Pet? GetPet(Guid id)
    {
        return dbContext.Pets.FirstOrDefault(p => p.Id == id);
    }

    public Guid AddOwner(Owner owner)
    {
        dbContext.Owners.Add(owner);
        dbContext.SaveChanges();
        return owner.Id;
    }

    public List<Owner> GetOwners()
    {
        return dbContext.Owners.ToList();
    }

    public Owner? GetOwner(Guid id)
    {
        return dbContext.Owners.FirstOrDefault(o => o.Id == id);
    }

    public List<Procedure> GetProcedures()
    {
        return dbContext.Procedures.ToList();
    }

    public List<Procedure> GetProcedures(Func<Procedure, bool> prediction)
    {
        return dbContext.Procedures.Where(prediction).ToList();
    }

    public Procedure? GetProcedure(Guid id)
    {
        return dbContext.Procedures.FirstOrDefault(p => p.Id == id);
    }

    public Guid AddProcedure(Procedure procedure)
    {
        dbContext.Procedures.Add(procedure);
        dbContext.SaveChanges();
        return procedure.Id;
    }

    public void UpdateProcedure(Procedure procedure)
    {
        dbContext.Procedures.Update(procedure);
        dbContext.SaveChanges();
    }

    public void DeleteProcedure(Procedure procedure)
    {
        dbContext.Procedures.Remove(procedure);
        dbContext.SaveChanges();
    }

    public void AddLogsVisitStatusUpdate(VisitStatusLog log)
    {
        dbContext.VisitStatusLogs.Add(log);
        dbContext.SaveChanges();
    }

    public List<VisitStatusLog> GetLogsVisitStatuses()
    {
        return dbContext.VisitStatusLogs.ToList();
    }

    public Guid AddVeterinarian(Veterinarian veterinarian)
    {
        dbContext.Veterinarians.Add(veterinarian);
        dbContext.SaveChanges();
        return veterinarian.Id;
    }

    public List<Veterinarian> GetVeterinarians()
    {
        return dbContext.Veterinarians.ToList();
    }

    public Veterinarian? GetVeterinarian(Guid id)
    {
        return dbContext.Veterinarians.FirstOrDefault(v => v.Id == id);
    }

    public Guid AddPetPassport(PetPassport passport)
    {
        dbContext.PetPassports.Add(passport);
        dbContext.SaveChanges();
        return passport.Id;
    }

    public List<PetPassport> GetPetPassports()
    {
        return dbContext.PetPassports.ToList();
    }
}