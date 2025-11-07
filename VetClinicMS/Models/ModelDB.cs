namespace VetClinicMS.Models;

public class ModelDB
{
    public List<Visit> visits { get; set; } = [];
    public List<Owner> owners { get; set; } = [];
    public List<Pet> pets { get; set; } = [];
    public List<Procedure> procedures { get; set; } = [];
    public List<VisitStatusLog> visitStatusLogs { get; set; } = [];
    public List<Veterinarian> Veterinarians { get; set; } = [];
    public List<PetPassport> PetPassports { get; set; } = [];
}