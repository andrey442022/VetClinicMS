namespace VetClinicMS.Models;

public class VisitStatusLog
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public Guid VisitId { get; set; }
    public VisitStatus OldStatus { get; set; }
    public VisitStatus NewStatus { get; set; }
}