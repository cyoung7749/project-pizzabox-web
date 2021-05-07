using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Size : Entity
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public override string ToString()
    {
      return $"{Name}";
    }
  }
}