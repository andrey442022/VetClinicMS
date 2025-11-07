using System.Collections;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS;

public class VisitService(IRepository repository)
{
    private IRepository repository = repository;

    public Visit AddVisit(Pet patient, List<Procedure> procedures, DateTime visitDate)
    {
        if (procedures == null || procedures.Count == 0)
            throw new ArgumentNullException(nameof(procedures));

        if (patient is null)
            throw new ArgumentNullException(nameof(patient));

        if (patient.Owner is null)
            throw new ArgumentNullException(nameof(patient.Owner));

        if (repository.GetPet(patient.Id) is null)
            throw new Exception("Pet not found is repository");

        if (repository.GetOwner(patient.Owner.Id) is null)
            throw new Exception("Owner not found is repository");

        var visit = new Visit
        {
            Date = visitDate,
            Patient = patient,
            Procedures = procedures,
            Status = VisitStatus.Registered
        };
        
        repository.AddVisit(visit);

        return visit;
    }

    private void ChangeStatus(Visit visit, VisitStatus newStatus)
    {
        if(visit == null)
            throw new Exception("Visit not found");
        
        repository.AddLogsVisitStatusUpdate(new VisitStatusLog()
        {
            VisitId = visit.Id,
            OldStatus = visit.Status,
            NewStatus = newStatus
        });
        
        visit.Status = newStatus;
        repository.UpdateVisit(visit);
    }

    public void CloseVisit(Visit visit)
    {
        if (visit == null)
            throw new Exception("Visit not found");
        
        if(visit.Procedures.Any(item=> !item.IsCompleted))
            throw new Exception("Procedures not completed");

        ChangeStatus(visit, VisitStatus.Completed);
        visit.EndDate = DateTime.Now;
        visit.Total = visit.Procedures.Sum(item => item.Price);
        repository.UpdateVisit(visit);
    }

    public Visit? GetVisit(Guid visitId)
    {
        return repository.GetVisit(visitId);
    }

    public List<Visit> GetVisits()
    {
        return repository.GetVisits();
    }
}