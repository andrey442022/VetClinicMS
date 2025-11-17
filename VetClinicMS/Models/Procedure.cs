using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace VetClinicMS.Models;

public class Procedure
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsBlocked { get; set; }
    public decimal CostPrice { get; set; }
    public List<string?>? Tags { get; set; }
    [NotMapped]
    public string TagsString => Tags?.Aggregate((current, next) => current + ", " + next) ?? "";
}