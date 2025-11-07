using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Logic;

public class StatiscitcsService(IRepository repository)
{
    public decimal TotalSumForDay(DateTime date)
    {
        return repository.GetVisits(item => item.EndDate != null && item.EndDate.Value.Date == date)
            .Sum(item => item.Total);
    }

    public (decimal total, int count) GetTotalSumAndCountVisitsForPeriod(DateTime start, DateTime end)
    {
        var visits = repository.GetVisits(item =>
            item.EndDate != null && item.EndDate.Value.Date >= start && item.EndDate.Value.Date <= end);
        var total = visits.Sum(item => item.Total);
        return (total, visits.Count);
    }

    public (int count, double average, double util) GetCabinetStatistics(
        string cabinetNumber,
        DateTime targetDate,
        double workingHoursPerDay = 8.0)
    {
        var allVisits = repository.GetVisits(item =>
            item.Office == cabinetNumber &&
            item.Status == VisitStatus.Completed &&
            item.Date.Date == targetDate.Date
        );

        if (allVisits.Count == 0) return (0, 0, 0);

        var totalBusyHours = allVisits.Select(visit => visit.EndDate!.Value - visit.Date)
            .Select(duration => duration.TotalHours).Sum();
        var average = allVisits.Average(item => (item.EndDate!.Value - item.Date).TotalSeconds);

        var utilization = (totalBusyHours / workingHoursPerDay) * 100.0;

        return (allVisits.Count, average, Math.Round(utilization, 2));
    }

    public (int count, decimal all, double average) GetStatisticsVeterinarian(Veterinarian veterinarian, DateTime start,
        DateTime end)
    {
        var allVisits = repository.GetVisits(item =>
            item.Veterinarian.Id == veterinarian.Id &&
            (item.Date.Date >= start.Date && item.Date.Date <= end.Date) &&
            item.Status == VisitStatus.Completed
        );

        var average = allVisits.Average(item => (item.EndDate!.Value - item.Date).TotalSeconds);

        return (allVisits.Count, allVisits.Sum(item => item.Total), average);
    }

    public (Dictionary<Procedure, int> mostUses, Dictionary<Procedure, decimal> mostExpensive) GetProceduresStatistics(DateTime start,
        DateTime end)
    {
        var allVisits = repository.GetVisits(item =>
            (item.Date.Date >= start.Date && item.Date.Date <= end.Date) &&
            item.Status == VisitStatus.Completed
        );

        var procedureGroups = allVisits
            .SelectMany(visit => visit.Procedures)
            .GroupBy(proc => proc.Id);

        var aggregatedData = procedureGroups.Select(g => new
        {
            Procedure = g.First(),          // Беремо сам об'єкт Procedure (він однаковий для всіх в групі)
            Count = g.Count(),              // Ефективно рахуємо кількість елементів в групі
            TotalSum = g.Sum(p => p.Price)  // Сумуємо вартість в межах групи
        }).ToList();
        
        var orderUses = aggregatedData
            .OrderByDescending(item => item.Count)
            .ToDictionary(item => item.Procedure, item => item.Count);

        var orderExpensive = aggregatedData
            .OrderByDescending(item => item.TotalSum)
            .ToDictionary(item => item.Procedure, item => item.TotalSum);

        return (orderUses, orderExpensive);
    }
}