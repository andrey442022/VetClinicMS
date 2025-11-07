using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Logic;

public class PetPassportService(IRepository repository)
{
    public PetPassport CreatePetPassport(Pet pet, Owner owner, List<string> issues)
    {
        var passport = new PetPassport()
        {
            Pet = pet,
            Owner = owner,
            Issues = issues
        };
        repository.AddPetPassport(passport);
        return passport;
    }

    public List<PetPassport> GetPetPassports()
    {
        return repository.GetPetPassports();
    }
}