using VetClinicMS.Classes;
using VetClinicMS.Interfaces;
using VetClinicMS.Logic;
using VetClinicMS.Models;

namespace VetClinicMS;

static class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        IRepository repository = new MemoryRepository();
        var procedureService = new ProcedureService(repository);
        var visitService = new VisitService(repository);
        var petService = new PetService(repository);
        var ownerService = new OwnerService(repository);

        procedureService.CreateProcedure("Вакцинація", 500);
        procedureService.CreateProcedure("Огляд",300);
        
        var owner = ownerService.RegisterOwner("Іван Петренко", phone:"0981234567");
        var pet = petService.RegisterPet("Боня", "Собака", "Такса", 4, owner);

        var newVisit = visitService.AddVisit(pet, procedureService.GetProcedures(), DateTime.Now);
        
        Console.WriteLine("Успішно створено запис на візит!");
        Console.WriteLine($"    Унікальний ID візиту: {newVisit.Id}");
        Console.WriteLine($"    Пацієнт: {newVisit.Patient.Name} (Власник: {newVisit.Patient.Owner.FullName})");
        Console.WriteLine($"    Дата: {newVisit.Date}");
        Console.WriteLine($"    Статус: {newVisit.Status}");
        Console.WriteLine($"    Кількість процедур: {newVisit.Procedures.Count}");
    }
}