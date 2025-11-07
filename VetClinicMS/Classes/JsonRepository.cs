using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Classes;

public class JsonRepository : IRepository
{
    [NonSerialized] private string mainFilePath = "db.json";
    public ModelDB DB { get; set; } = new ();
    public JsonRepository()
    {
        if (File.Exists(mainFilePath))
        {
            var data = File.ReadAllText(mainFilePath);
            DB = JsonSerializer.Deserialize<ModelDB>(data)!;
        }
    }

    public Guid AddVisit(Visit visit)
    {
        if(visit.Procedures == null)
            throw new NoNullAllowedException(nameof(visit.Procedures));
        if(visit.Patient == null)
            throw new NoNullAllowedException(nameof(visit.Patient));
        if(visit.Patient.Owner == null)
            throw new NoNullAllowedException(nameof(visit.Patient.Owner));
        
        if (DB.procedures.Intersect(visit.Procedures).Count() != visit.Procedures.Count)
            throw new Exception("Procedure not found is repository");
        
        visit.Id = Guid.NewGuid();
        DB.visits.Add(visit);
        SaveToFile();
        return visit.Id;
    }

    public List<Visit> GetVisits()
    {
        return DB.visits.ToList();
    }

    public List<Visit> GetVisits(Func<Visit, bool> prediction)
    {
        return DB.visits.Where(prediction).ToList();
    }

    public Visit GetVisit(Guid id)
    {
        return DB.visits.First(item => item.Id == id);
    }

    public void UpdateVisit(Visit visit)
    {
        var  findIndex = DB.visits.FindIndex(item => item.Id == visit.Id);
        if (findIndex == -1)
            throw new Exception("Visit with id " + visit.Id + " not found");
        
        DB.visits[findIndex] = visit;
        SaveToFile();
    }

    public Guid AddPet(Pet pet)
    {
        pet.Id = Guid.NewGuid();
        DB.pets.Add(pet);
        SaveToFile();
        return pet.Id;
    }

    public List<Pet> GetPets()
    {
        return DB.pets.ToList();
    }

    public Pet? GetPet(Guid id)
    {
        return DB.pets.FirstOrDefault(item => item.Id == id);
    }

    public Guid AddOwner(Owner owner)
    {
        owner.Id = Guid.NewGuid();
        DB.owners.Add(owner);
        SaveToFile();
        return owner.Id;
    }

    public List<Owner> GetOwners()
    {
        return DB.owners.ToList();
    }

    public Owner? GetOwner(Guid id)
    {
        return DB.owners.FirstOrDefault(item => item.Id == id);
    }

    public List<Procedure> GetProcedures()
    {
        return DB.procedures.ToList();
    }

    public List<Procedure> GetProcedures(Func<Procedure, bool> prediction)
    {
        return DB.procedures.Where(prediction).ToList();
    }

    public Procedure? GetProcedure(Guid id)
    {
        return DB.procedures.FirstOrDefault(item => item.Id == id);
    }

    public Guid AddProcedure(Procedure guid)
    {
        guid.Id = Guid.NewGuid();
        DB.procedures.Add(guid);
        SaveToFile();
        return guid.Id;
    }

    public void UpdateProcedure(Procedure procedure)
    {
        var find = DB.procedures.FirstOrDefault(item => item.Id == procedure.Id);
        if (find == null)
            throw new Exception("Procedure with id " + procedure.Id + " not find");

        find.Name = procedure.Name;
        find.Price = procedure.Price;
        SaveToFile();
    }

    public void DeleteProcedure(Procedure procedure)
    {
        DB.procedures.Remove(procedure);
        SaveToFile();
    }

    public void AddLogsVisitStatusUpdate(VisitStatusLog log)
    {
        log.Id = Guid.NewGuid();
        DB.visitStatusLogs.Add(log);
        SaveToFile();
    }

    public List<VisitStatusLog> GetLogsVisitStatuses()
    {
        return DB.visitStatusLogs.ToList();
    }

    public Guid AddVeterinarian(Veterinarian veterinarian)
    {
        veterinarian.Id = Guid.NewGuid();
        DB.Veterinarians.Add(veterinarian);
        SaveToFile();
        return veterinarian.Id;
    }

    public List<Veterinarian> GetVeterinarians()
    {
        return DB.Veterinarians.ToList();
    }

    public Veterinarian? GetVeterinarian(Guid id)
    {
        return DB.Veterinarians.FirstOrDefault(item => item.Id == id);
    }

    public Guid AddPetPassport(PetPassport passport)
    {
        passport.Id =  Guid.NewGuid();
        DB.PetPassports.Add(passport);
        SaveToFile();
        return passport.Id;
    }

    public List<PetPassport> GetPetPassports()
    {
        return DB.PetPassports.ToList();
    }

    private void SaveToFile()
    {
        File.WriteAllText(mainFilePath, JsonSerializer.Serialize(DB));
    }
}