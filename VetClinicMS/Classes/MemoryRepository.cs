using System.Text.Json;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Classes;

public class MemoryRepository : IRepository
{
    private ModelDB DB { get; set; } = new();

    public Guid AddVisit(Visit visit)
    {
        if (DB.procedures.Intersect(visit.Procedures).Count() != visit.Procedures.Count)
        {
            throw new Exception("Procedure not found is repository");
        }

        visit.Id = Guid.NewGuid();
        DB.visits.Add(visit);
        return visit.Id;
    }

    public List<Visit> GetVisits()
    {
        return DB.visits;
    }

    public Visit? GetVisit(Guid id)
    {
        return DB.visits.FirstOrDefault(item => item.Id == id);
    }

    public Guid AddPet(Pet pet)
    {
        pet.Id = Guid.NewGuid();
        DB.pets.Add(pet);
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

    public Procedure? GetProcedure(Guid id)
    {
        return DB.procedures.FirstOrDefault(item => item.Id == id);
    }

    public Guid AddProcedure(Procedure guid)
    {
        guid.Id = Guid.NewGuid();
        DB.procedures.Add(guid);
        return guid.Id;
    }

    public void UpdateProcedure(Procedure procedure)
    {
        var find = DB.procedures.FirstOrDefault(item => item.Id == procedure.Id);
        if (find == null)
            throw new Exception("Procedure with id " + procedure.Id + " not find");

        find.Name = procedure.Name;
        find.Price = procedure.Price;
    }

    public void DeleteProcedure(Procedure procedure)
    {
        DB.procedures.Remove(procedure);
    }
}