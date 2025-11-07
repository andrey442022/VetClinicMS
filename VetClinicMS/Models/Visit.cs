namespace VetClinicMS.Models;

public class Visit
{
    public System.Guid Id { get; set; }
    public DateTime Date { get; set; }
    public VisitStatus Status { get; set; }
    public Pet Patient { get; set; }
    public List<Procedure> Procedures { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal Total { get; set; }
    public string Office { get; set; }
    public Veterinarian Veterinarian { get; set; }
}

public enum VisitStatus
{
    Registered,
    InProgress,
    Completed,
    Cancelled
}