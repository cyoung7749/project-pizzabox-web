using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository : IRepository<Pizza>
  {
    private readonly PizzaBoxContext _context;

    public PizzaRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Pizza> Create(Func<Pizza, bool> filter)
    {
      throw new System.NotImplementedException();
    }
    public Pizza Read()
    {
      throw new System.NotImplementedException();
    }
    public bool Update(Pizza entry)
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}