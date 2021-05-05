using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    public IEnumberable<Order> Create(){} //Select
    public Order Update(){} //Insert
    public IEnumberable<Order> Read(){} //Update
    public Order Delete(){}
  }
}