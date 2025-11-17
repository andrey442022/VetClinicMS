using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Logic;

public class OwnerService(IRepository rep)
{
    private readonly IRepository repository = rep;

    public Owner RegisterOwner(string name, string phone = "", string email = "")
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("Owner name is required");
        var owner = new Owner
        {
            FullName = name,
            Phone = phone,
            Email = email
        };
        repository.AddOwner(owner);
        return owner;
    }

    public Owner? GetOwner(Guid id)
    {
        return repository.GetOwner(id);
    }

    public List<Owner> GetOwners()
    {
        return repository.GetOwners();
    }
}