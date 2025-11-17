using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinicMS.Models;

public class ProcedureVisit
{
    public Guid Id { get; set; }
    public Procedure Procedure { get; set; }
    public bool IsCompleted { get; set; } = false;

    [NotMapped]
    public string ProcedureName => Procedure.Name;
    [NotMapped]
    public decimal ProcedurePrice => Procedure.Price;

    public override string ToString()
    {
        return Procedure.Name;
    }
}