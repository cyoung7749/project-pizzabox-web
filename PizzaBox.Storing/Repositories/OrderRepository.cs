using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    private readonly PizzaBoxContext _context;
    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Order> Create(Func<Order, bool> filter)
    {
      throw new System.NotImplementedException();
    } //Select
    public bool Update(Order entry)
    {
      _context.Orders.Add(entry);
      return true;
    } //Insert
    public Order Read() { throw new System.NotImplementedException(); } //Update
    public bool Delete() { throw new System.NotImplementedException(); }
  }
}