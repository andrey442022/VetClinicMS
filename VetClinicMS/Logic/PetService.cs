using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Logic;

public class PetService(IRepository repository)
{
    public Pet RegisterPet(string name, string species, string breed, int age, Owner owner)
    {
        if (repository.GetOwner(owner.Id) == null)
            throw new KeyNotFoundException("Власника не знайдено.");

        var pet = new Pet
        {
            Name = name,
            Species = species,
            Breed = breed,
            Age = age,
            Owner = owner
        };
        repository.AddPet(pet);
        return pet;
    }

    public Pet? GetPet(Guid id)
    {
        return repository.GetPet(id);
    }

    public List<Pet> GetPets()
    {
        return repository.GetPets();
    }
}