using System.ComponentModel.DataAnnotations;


namespace FruitWebApp.Models;

public class FruitModel
{
    [Key]
    public int Id { get; set; }

    [Display(Name="Fruit Name")]
    public string? Name { get; set; }
    [Display(Name ="Available?")]
    public bool Instock { get; set; }
}
