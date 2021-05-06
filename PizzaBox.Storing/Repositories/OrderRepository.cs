using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    public IEnumerable<Order> Create(){throw new System.NotImplementedException();} //Select
    public bool Update(){throw new System.NotImplementedException();} //Insert
    public Order Read(){throw new System.NotImplementedException();} //Update
    public bool Delete(){throw new System.NotImplementedException();}
  }
}