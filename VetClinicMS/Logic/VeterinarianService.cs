using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Logic;

public class VeterinarianService(IRepository repository)
{
    public Veterinarian CreateVeterinarian(string name, string specialization)
    {
        var veterinarian = new Veterinarian()
        {
            FullName = name,
            Specialization = specialization
        };
        repository.AddVeterinarian(veterinarian);
        return veterinarian;
    }

    public List<Veterinarian> GetVeterinarians()
    {
        return repository.GetVeterinarians();
    }

    public Veterinarian? GetVeterinarian(Guid id)
    {
        return repository.GetVeterinarian(id);
    }
}