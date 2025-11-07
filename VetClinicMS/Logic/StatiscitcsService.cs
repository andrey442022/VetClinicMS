using VetClinicMS.Interfaces;

namespace VetClinicMS.Logic;

public class StatiscitcsService(IRepository repository)
{
    public decimal TotalSumForDay(DateTime date)
    {
        return repository.GetVisits(item => item.EndDate != null && item.EndDate.Value.Date == date).Sum(item => item.Total);
    }
}