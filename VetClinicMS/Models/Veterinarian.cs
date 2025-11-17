namespace VetClinicMS.Models;

public class Veterinarian
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Specialization { get; set; }

    public override string ToString()
    {
        return FullName;
    }
}