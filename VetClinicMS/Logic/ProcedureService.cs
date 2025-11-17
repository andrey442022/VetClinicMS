using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Logic;

public class ProcedureService(IRepository repository)
{
    public List<Procedure> GetProcedures()
    {
        return repository.GetProcedures();
    }

    public List<Procedure> GetActualProcedures()
    {
        return repository.GetProcedures(item => !item.IsBlocked);
    }

    public Procedure? GetProcedure(Guid id)
    {
        return repository.GetProcedure(id);
    }

    public Procedure CreateProcedure(string name, decimal price, decimal costPrice = 0, List<string>? tags = null)
    {
        if (string.IsNullOrEmpty(name)) throw new Exception("Name is required");

        if (price == 0) throw new Exception("Price is required");

        var procedure = new Procedure
        {
            Name = name,
            Price = price,
            CostPrice = costPrice,
            Tags = tags
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