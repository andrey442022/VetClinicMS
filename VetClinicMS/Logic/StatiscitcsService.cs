using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Logic;

public class StatiscitcsService(IRepository repository)
{
    public decimal TotalSumForDay(DateTime date)
    {
        return repository.GetVisits(item => item.EndDate != null && item.EndDate.Value.Date == date).Sum(item => item.Total);
    }

    public (decimal total, int count) GetTotalSumAndCountVisitsForPeriod(DateTime start, DateTime end)
    {
        var visits = repository.GetVisits(item => item.EndDate != null && item.EndDate.Value.Date >= start && item.EndDate.Value.Date <= end);
        var total = visits.Sum(item => item.Total); 
        return (total, visits.Count);
    }
    
    public (int count, double average, double util) GetCabinetStatiscitc(
        string cabinetNumber, 
        DateTime targetDate, 
        double workingHoursPerDay = 8.0)
    {
        var allVisits = repository.GetVisits(v => 
            v.Office == cabinetNumber && 
            v.Status == VisitStatus.Completed && 
            v.EndDate!.Value.Date == targetDate.Date
        );

        if (allVisits.Count == 0) return (0, 0, 0);
        
        var totalBusyHours = allVisits.Select(visit => visit.EndDate!.Value - visit.Date).Select(duration => duration.TotalHours).Sum();
        var average = allVisits.Average(item => (item.EndDate.Value - item.Date).TotalSeconds);

        var utilization = (totalBusyHours / workingHoursPerDay) * 100.0;
        
        return (allVisits.Count, average ,Math.Round(utilization, 2));
    }
}