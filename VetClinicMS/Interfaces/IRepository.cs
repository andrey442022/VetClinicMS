using VetClinicMS.Models;

namespace VetClinicMS.Interfaces;

public interface IRepository
{
    public Guid AddVisit(Visit visit);
    public List<Visit> GetVisits();
    public List<Visit> GetVisits(Func<Visit, bool> prediction);
    public Visit? GetVisit(Guid id);
    public void UpdateVisit(Visit visit);

    public Guid AddPet(Pet pet);
    public List<Pet> GetPets();
    public Pet? GetPet(Guid id);

    public Guid AddOwner(Owner owner);
    public List<Owner> GetOwners();
    public Owner? GetOwner(Guid id);

    public List<Procedure> GetProcedures();
    public List<Procedure> GetProcedures(Func<Procedure, bool> prediction);
    public Procedure? GetProcedure(Guid id);
    public Guid AddProcedure(Procedure procedure);
    public void UpdateProcedure(Procedure procedure);
    public void DeleteProcedure(Procedure procedure);

    public void AddLogsVisitStatusUpdate(VisitStatusLog log);
    public List<VisitStatusLog> GetLogsVisitStatuses();

    public Guid AddVeterinarian(Veterinarian veterinarian);
    public List<Veterinarian> GetVeterinarians();
    public Veterinarian? GetVeterinarian(Guid id);

    public Guid AddPetPassport(PetPassport passport);
    public List<PetPassport> GetPetPassports();
}