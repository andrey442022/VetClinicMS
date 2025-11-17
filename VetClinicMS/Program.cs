using System.Globalization;
using VetClinicMS.Classes;
using VetClinicMS.Interfaces;
using VetClinicMS.Logic;
using VetClinicMS.Models;

namespace VetClinicMS;

static class Program
{
    private static IRepository repository = null!;
    private static ProcedureService procedureService = null!;
    private static VisitService visitService = null!;
    private static PetService petService = null!;
    private static OwnerService ownerService = null!;
    private static StatiscitcsService statisticsService = null!;
    private static VeterinarianService veterinarianService = null!;
    private static PetPassportService petPassportService = null!;

    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        repository = new DbRepository();
        procedureService = new ProcedureService(repository);
        visitService = new VisitService(repository);
        petService = new PetService(repository);
        ownerService = new OwnerService(repository);
        statisticsService = new StatiscitcsService(repository);
        veterinarianService = new VeterinarianService(repository);
        petPassportService = new PetPassportService(repository);

        if (procedureService.GetProcedures().All(p => p.Name != "Вакцинація"))
        {
            procedureService.CreateProcedure("Вакцинація", 500);
        }

        if (procedureService.GetProcedures().All(p => p.Name != "Огляд"))
        {
            procedureService.CreateProcedure("Огляд", 300);
        }

        RunMainMenu();
    }

    private static void RunMainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- 🏥 Система управління ветеринарною клінікою ---");
            Console.WriteLine("1. Додати нового лікаря");
            Console.WriteLine("2. Додати нового власника");
            Console.WriteLine("3. Додати нову тварину");
            Console.WriteLine("4. Записати на візит");
            Console.WriteLine("5. Закриття візиту");
            Console.WriteLine("6. Переглянути статистику");
            Console.WriteLine("7. Блокування/Розблокування процедури");
            Console.WriteLine("8. Додавання паспорта тварини");
            Console.WriteLine("9. Вихід");
            Console.Write("\nОберіть опцію: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewVeterinarian();
                    break;
                case "2":
                    AddNewOwner();
                    break;
                case "3":
                    AddNewPet();
                    break;
                case "4":
                    CreateNewVisit();
                    break;
                case "5":
                    CloseVisit();
                    break;
                case "6":
                    ShowMenuStatistics();
                    break;
                case "7":
                    BlockProcedures();
                    break;
                case "8":
                    AddNewPetPassport();
                    break;
                case "9":
                    Console.WriteLine("Дякуємо за використання! Вихід...");
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Натисніть [Enter] для повторної спроби.");
                    Console.ReadLine();
                    break;
            }
        }
    }
    
    private static void ShowMenuStatistics()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---  🏥 Система управління ветеринарною клінікою ---");
            Console.WriteLine("---              📈 Перегляд статистики          ---");
            Console.WriteLine("1. Перегляд статистики за період");
            Console.WriteLine("2. Перегляд статистики по кабінетам");
            Console.WriteLine("3. Перегляд статистики по лікарю");
            Console.WriteLine("4. Перегляд статистики по процедурам");
            Console.WriteLine("9. Вихід");
            Console.Write("\nОберіть опцію: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowStatisticsForPeriod();
                    break;
                case "2":
                    ShowStatisticsForOffice();
                    break;
                case "3":
                    ShowStatisticsForVeterinarian();
                    break;
                case "4":
                    ShowStatisticsForProcedures();
                    break;
                case "9":
                    Console.WriteLine("Повернення на головне меню...");
                    return;
                default:
                    Console.WriteLine("Невірний вибір. Натисніть [Enter] для повторної спроби.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private static void ShowStatisticsForProcedures()
    {
        Console.Clear();
        Console.WriteLine("--- 🏢 Статистика по процедурам ---");
        
        Console.Write("Введіть дату з якого: ");
        var dateStartString = Console.ReadLine();

        var start = DateTime.Now;

        if (DateTime.TryParse(dateStartString, out var startParseDate))
            start = startParseDate;
        
        Console.Write("Введіть дату по яке: ");
        var dateEndString = Console.ReadLine();

        var end = start.AddDays(1);

        if (DateTime.TryParse(dateEndString, out var endParseDate))
            end = endParseDate;

        var statistics = statisticsService.GetProceduresStatistics(start, end);

        
        Console.WriteLine("--- 📈 Найчастіше виконувані ---");
        for (var i = 0; i < statistics.mostUses.Count; i++)
        {
            var item = statistics.mostUses.ElementAt(i);
            
            Console.WriteLine($"Процедура \"{item.Key.Name}\", кількість разів: {item.Value}");
        }
        
        Console.WriteLine("--- 💰 Найбільш прибуткові ---");
        for (var i = 0; i < statistics.mostExpensive.Count; i++)
        {
            var item = statistics.mostExpensive.ElementAt(i);
            
            Console.WriteLine($"Процедура \"{item.Key.Name}\", всього: {item.Value}");
        }

        PauseScreen();
    }

    private static void ShowStatisticsForVeterinarian()
    {
        Console.Clear();
        Console.WriteLine("--- 🏢 Статистика по кабінету ---");

        var veterinarian = FindVeterinarian();
        if(veterinarian == null) return;

        Console.Write("Введіть дату з якого: ");
        var dateStartString = Console.ReadLine();

        var start = DateTime.Now;

        if (DateTime.TryParse(dateStartString, out var startParseDate))
            start = startParseDate;
        
        Console.Write("Введіть дату по яке: ");
        var dateEndString = Console.ReadLine();

        var end = start.AddDays(1);

        if (DateTime.TryParse(dateEndString, out var endParseDate))
            end = endParseDate;

        var statistics = statisticsService.GetStatisticsVeterinarian(veterinarian, start, end);

        Console.WriteLine(
            $"\nСтатистика по лікарю {veterinarian.FullName} з {start.ToShortDateString()} по {end.ToShortDateString()}:" +
            $"\n    Усього візитів {statistics.count}" +
            $"\n    Виручка {statistics.all}" +
            $"\n    Середній час обслуговування {Math.Round(statistics.average / 60)} хвилин");

        PauseScreen();
    }

    private static void ShowStatisticsForOffice()
    {
        Console.Clear();
        Console.WriteLine("--- 🏢 Статистика по кабінету ---");

        Console.Write("Введіть номер кабінету: ");
        var office = Console.ReadLine() ?? "101";

        Console.Write("Введіть дату: ");
        var dateString = Console.ReadLine();

        var date = DateTime.Now;

        if (DateTime.TryParse(dateString, out var parseDate))
            date = parseDate;

        var statistics = statisticsService.GetCabinetStatistics(office, date);

        Console.WriteLine(
            $"\nСтатистика по кабінету {office} за {date.ToShortDateString()}:" +
            $"\n    Усього візитів {statistics.count}" +
            $"\n    Середній час візиту {Math.Round(statistics.average / 60)} хвилин" +
            $"\n    Завантаженість кабінету {statistics.util}%");

        PauseScreen();
    }

    private static void ShowStatisticsForPeriod()
    {
        Console.Clear();
        Console.WriteLine("--- 📅 Статистика за період ---");

        Console.WriteLine("За день - 0");
        Console.WriteLine("За тиждень - 1");
        Console.WriteLine("За місяць - 2");
        Console.WriteLine("За рік - 3");

        Console.Write("Оберіть опцію: ");
        var input = Console.ReadLine() ?? "0";

        var start = DateTime.Today;
        var end = input switch
        {
            "1" => start.AddDays(7),
            "2" => start.AddMonths(1),
            "3" => start.AddYears(1),
            _ => start.AddDays(1)
        };

        var statistics = statisticsService.GetTotalSumAndCountVisitsForPeriod(start, end);

        Console.WriteLine($"Статистика за період: з {start.ToShortDateString()} по {end.ToShortDateString()}");
        Console.WriteLine($"Усього закрито візитів {statistics.count}, на суму: {statistics.total}");

        PauseScreen();
    }
    
        private static void AddNewPetPassport()
    {
        Console.Clear();
        Console.WriteLine("--- 👤 Додавання нового паспорта тварини ---");

        var pet = FindPet();
        if (pet == null) return;

        var listIssues = new List<string>();
        Console.WriteLine(
            "Додавання проведені вакцинації, протипаразитні процедури, історія хвороб (лише ті що можуть створювати обмеження для майбутніх процедур: хронічні хвороби, алергії, операції):");
        while (true)
        {
            Console.Write("Введіть інформацію або q для завершення вводу:");
            var input = Console.ReadLine();

            if (input == "q")
            {
                if (listIssues.Count != 0)
                    break;

                Console.WriteLine("Потрібно ввести хочаб одну інформацію!");
                continue;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Строка не може бути пустою");
            }
            else
            {
                listIssues.Add(input);
            }
        }

        var petPassport = petPassportService.CreatePetPassport(pet, pet.Owner, listIssues);

        Console.WriteLine($"\n✅ Успішно створено паспорт!");
        Console.WriteLine($"   ID: {petPassport.Id}");
        Console.WriteLine($"   Тварина: {petPassport.Pet.Name}");
        Console.WriteLine($"   Власник: {petPassport.Owner.FullName}");
        PauseScreen();
    }

    private static void AddNewVeterinarian()
    {
        Console.Clear();
        Console.WriteLine("--- 👤 Додавання нового лікаря ---");

        Console.Write("Введіть ПІБ: ");
        var name = Console.ReadLine() ?? "N/A";

        Console.Write("Введіть спеціалізацію: ");
        var specialization = Console.ReadLine() ?? "N/A";

        var owner = veterinarianService.CreateVeterinarian(name, specialization);

        Console.WriteLine($"\n✅ Успішно створено лікаря!");
        Console.WriteLine($"   ID: {owner.Id}");
        Console.WriteLine($"   ПІБ: {owner.FullName}");
        Console.WriteLine($"   Cпеціалізація: {owner.Specialization}");
        PauseScreen();
    }


    private static void BlockProcedures()
    {
        Console.Clear();
        Console.WriteLine("--- 🔑 Блокування/Розблокування процедури ---");

        var procedure = FindProcedure();
        if (procedure == null) return;

        Console.WriteLine($"\nОбрано процедуру: {procedure.Name}");

        Console.Write("Заблокувати - 1, Розблокувати - 0: ");
        var input = Console.ReadLine() ?? "0";

        procedure.IsBlocked = input == "1";
        procedureService.UpdateProcedure(procedure);
        Console.WriteLine(procedure.IsBlocked ? $"\n✅ Процедура заблокована!" : $"\n✅ Процедура розблокована!");

        PauseScreen();
    }

    private static void CloseVisit()
    {
        Console.Clear();
        Console.WriteLine("--- ❎ Закритя візиту ---");

        var visit = FindVisit();
        if (visit == null || visit.EndDate != null) return; // Пошук скасовано або не вдався

        Console.WriteLine($"\nОбрано візит: {visit.Date}");

        visit.Procedures.ForEach(item => item.IsCompleted = true);

        visitService.CloseVisit(visit);

        Console.WriteLine($"\n✅ Візит успішно закрито!");

        PauseScreen();
    }

    private static void AddNewOwner()
    {
        Console.Clear();
        Console.WriteLine("--- 👤 Додавання нового власника ---");

        Console.Write("Введіть ПІБ: ");
        var name = Console.ReadLine() ?? "N/A";

        Console.Write("Введіть телефон: ");
        var phone = Console.ReadLine() ?? "N/A";

        var owner = ownerService.RegisterOwner(name, phone);

        Console.WriteLine($"\n✅ Успішно створено власника!");
        Console.WriteLine($"   ID: {owner.Id}");
        Console.WriteLine($"   ПІБ: {owner.FullName}");
        PauseScreen();
    }

    private static void AddNewPet()
    {
        Console.Clear();
        Console.WriteLine("--- 🐶 Додавання нової тварини ---");
        
        var owner = FindOwner();
        if (owner == null) return;

        Console.WriteLine($"\nОбрано власника: {owner.FullName}");

        Console.Write("Введіть кличку тварини: ");
        var name = Console.ReadLine() ?? "N/A";

        Console.Write("Введіть вид (напр., 'Собака', 'Кіт'): ");
        var type = Console.ReadLine() ?? "N/A";

        Console.Write("Введіть породу: ");
        var breed = Console.ReadLine() ?? "N/A";

        int age = 0;
        while (true)
        {
            Console.Write("Введіть вік (повних років): ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            {
                break;
            }

            Console.WriteLine("Невірний формат. Введіть число.");
        }

        var pet = petService.RegisterPet(name, type, breed, age, owner);

        Console.WriteLine($"\n✅ Успішно зареєстровано тварину!");
        Console.WriteLine($"   ID: {pet.Id}");
        Console.WriteLine($"   Кличка: {pet.Name}");
        Console.WriteLine($"   Власник: {pet.Owner.FullName}");
        PauseScreen();
    }

    private static void CreateNewVisit()
    {
        Console.Clear();
        Console.WriteLine("--- 📅 Створення нового візиту ---");

        var pet = FindPet();
        if (pet == null) return;

        Console.WriteLine($"\nОбрано пацієнта: {pet.Name} (Власник: {pet.Owner.FullName})");

        var veterinarian = FindVeterinarian();
        if (veterinarian == null) return;

        Console.WriteLine($"\nОбрано лікаря: {veterinarian.FullName} (Спеціалізація: {veterinarian.Specialization})");

        var allProcedures = procedureService.GetActualProcedures();
        var proceduresForVisit = new List<Procedure>();

        while (true)
        {
            Console.WriteLine("\nДоступні процедури:");
            for (int i = 0; i < allProcedures.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {allProcedures[i].Name} ({allProcedures[i].Price:C})");
            }

            Console.Write("\nОберіть процедуру (введіть номер, або 0 для завершення): ");

            if (int.TryParse(Console.ReadLine(), out int procChoice) && procChoice > 0 &&
                procChoice <= allProcedures.Count)
            {
                var chosenProc = allProcedures[procChoice - 1];
                if (!proceduresForVisit.Contains(chosenProc))
                {
                    proceduresForVisit.Add(chosenProc);
                    Console.WriteLine($"   -> Додано: {chosenProc.Name}");
                }
                else
                {
                    Console.WriteLine("   -> Цю процедуру вже додано.");
                }
            }
            else if (procChoice == 0)
            {
                if (proceduresForVisit.Count == 0)
                {
                    Console.WriteLine("Ви повинні обрати хоча б одну процедуру.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Невірний номер.");
            }
        }

        Console.Write("Введіть номер кабінет: ");
        var office = Console.ReadLine() ?? "N/A";

        Console.Write("Введіть дату візита: ");
        var dateString = Console.ReadLine();

        var date = DateTime.Now;

        if (DateTime.TryParse(dateString, out var parseDate))
            date = parseDate;

        var newVisit = visitService.AddVisit(pet, proceduresForVisit, date, office, veterinarian);

        Console.WriteLine($"\n✅ Успішно створено візит!");
        Console.WriteLine($"   ID візиту: {newVisit.Id}");
        Console.WriteLine($"   Статус: {newVisit.Status}");
        PauseScreen();
    }

    private static void ShowDayStatistics()
    {
        Console.Clear();
        Console.WriteLine("--- 📊 Статистика за день ---");

        DateTime date;
        while (true)
        {
            Console.Write("Введіть дату (ДД.ММ.РРРР), або залиште пустим для сьогодні: ");
            string? dateStr = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dateStr))
            {
                date = DateTime.Today;
                break;
            }

            if (DateTime.TryParseExact(dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out date))
            {
                break;
            }

            Console.WriteLine("Невірний формат дати. Спробуйте ще раз (напр., 25.10.2025).");
        }

        var total = statisticsService.TotalSumForDay(date);

        Console.WriteLine($"\nЗагальний дохід за {date:dd.MM.yyyy}: {total:C}");
        PauseScreen();
    }

    private static Owner? FindOwner()
    {
        while (true)
        {
            foreach (var owner in ownerService.GetOwners())
            {
                Console.WriteLine($"Власника: {owner.FullName} ({owner.Id})");
            }

            Console.Write("Введіть ID власника (або 'q' для виходу): ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "q") return null;

            if (Guid.TryParse(input, out Guid ownerId))
            {
                var owner = ownerService.GetOwner(ownerId);
                if (owner != null)
                {
                    return owner;
                }

                Console.WriteLine("Власника з таким ID не знайдено.");
            }
            else
            {
                Console.WriteLine("Невірний формат ID.");
            }
        }
    }

    private static Pet? FindPet()
    {
        while (true)
        {
            foreach (var pet in petService.GetPets())
            {
                Console.WriteLine($"Тварина: {pet.Name} (Власник: {pet.Owner.FullName}) ({pet.Id})");
            }

            Console.Write("Введіть ID тварини (або 'q' для виходу): ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "q") return null;

            if (Guid.TryParse(input, out Guid petId))
            {
                var pet = petService.GetPet(petId);
                if (pet != null)
                {
                    return pet;
                }

                Console.WriteLine("Тварину з таким ID не знайдено.");
            }
            else
            {
                Console.WriteLine("Невірний формат ID.");
            }
        }
    }

    private static Visit? FindVisit()
    {
        while (true)
        {
            foreach (var visit in visitService.GetVisits(item => item.EndDate == null))
            {
                Console.WriteLine($"Візит паціента {visit.Patient.Name}, дата: {visit.Date} ({visit.Id})");
            }

            Console.Write("Введіть ID візиту (або 'q' для виходу): ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "q") return null;

            if (Guid.TryParse(input, out Guid visitId))
            {
                var visit = visitService.GetVisit(visitId);
                if (visit != null)
                {
                    return visit;
                }

                Console.WriteLine("Візит з таким ID не знайдено.");
            }
            else
            {
                Console.WriteLine("Невірний формат ID.");
            }
        }
    }

    public static Procedure? FindProcedure()
    {
        while (true)
        {
            foreach (var procedure in procedureService.GetProcedures())
            {
                Console.WriteLine($"Процедура {procedure.Name} ({procedure.Id})");
            }

            Console.Write("Введіть ID процедури (або 'q' для виходу): ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "q") return null;

            if (Guid.TryParse(input, out Guid procedureId))
            {
                var procedure = procedureService.GetProcedure(procedureId);
                if (procedure != null)
                {
                    return procedure;
                }

                Console.WriteLine("Процедура з таким ID не знайдено.");
            }
            else
            {
                Console.WriteLine("Невірний формат ID.");
            }
        }
    }

    private static Veterinarian? FindVeterinarian()
    {
        while (true)
        {
            foreach (var veterinarian in veterinarianService.GetVeterinarians())
            {
                Console.WriteLine($"Лікарь {veterinarian.FullName} ({veterinarian.Id})");
            }

            Console.Write("Введіть ID лікаря (або 'q' для виходу): ");
            var input = Console.ReadLine() ?? "";

            if (input?.ToLower() == "q") return null;

            if (Guid.TryParse(input, out Guid veterinarianId))
            {
                var veterinarian = veterinarianService.GetVeterinarian(veterinarianId);
                if (veterinarian != null)
                {
                    return veterinarian;
                }

                Console.WriteLine("Лікаря з таким ID не знайдено.");
            }
            else
            {
                Console.WriteLine("Невірний формат ID.");
            }
        }
    }

    private static void PauseScreen()
    {
        Console.WriteLine("\nНатисніть [Enter] для продовження...");
        Console.ReadLine();
    }
}