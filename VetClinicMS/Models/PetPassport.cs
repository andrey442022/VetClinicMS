namespace VetClinicMS.Models;

public class PetPassport
{
    public Guid Id { get; set; }
    public Pet Pet { get; set; }
    public List<string> Issues { get; set; }
    public Owner Owner { get; set; }
}