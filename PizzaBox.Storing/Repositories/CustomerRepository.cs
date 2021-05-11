using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class CustomerRepository : IRepository<Customer>
  {
    private readonly PizzaBoxContext _context;
    public CustomerRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Customer> Create(Func<Customer, bool> filter) //Select
    {
      return _context.Customers.Where(filter);
    }
    public bool Update(Customer entry) //Insert
    {
      throw new System.NotImplementedException();
    }
    public Customer Read()//Update
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}
