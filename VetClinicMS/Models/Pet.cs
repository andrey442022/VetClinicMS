namespace VetClinicMS.Models;

public class Pet
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public Owner Owner { get; set; }
}