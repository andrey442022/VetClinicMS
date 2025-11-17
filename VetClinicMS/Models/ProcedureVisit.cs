namespace VetClinicMS.Models;

public class ProcedureVisit
{
    public Guid Id { get; set; }
    public Procedure Procedure { get; set; }
    public bool IsCompleted { get; set; } = false;
}