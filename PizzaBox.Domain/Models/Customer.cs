using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Customer : Entity
  {
    public string Name { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}