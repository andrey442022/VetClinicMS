using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS;

public class ProcedureService(IRepository repository)
{
    public List<Procedure> GetProcedures()
    {
        return repository.GetProcedures();
    }

    public Procedure? GetProcedure(Guid id)
    {
        return repository.GetProcedure(id);
    }

    public Procedure CreateProcedure(string name, decimal price)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name is required");
        }
        
        if (price == 0)
        {
            throw new Exception("Price is required");
        }

        var procedure = new Procedure()
        {
            Name = name,
            Price = price
        };
        repository.AddProcedure(procedure);
        return procedure;
    }

    public void UpdateProcedure(Procedure procedure)
    {
        repository.UpdateProcedure(procedure);
    }

    public void DeleteProcedure(Procedure procedure)
    {
        repository.DeleteProcedure(procedure);
    }
}