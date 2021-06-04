using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : Entity
  {
    public Crust Crust { get; set; }
    //do I need to define entity ID for 
    public Size Size { get; set; }
    public Order Order { get; set; }

    public List<Topping> Toppings { get; set; }

    public long CrustEntityId { get; set; }
    public long SizeEntityId { get; set; }
    public long OrderEntityId { get; set; }
  }
}