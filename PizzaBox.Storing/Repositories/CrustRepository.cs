using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    private readonly PizzaBoxContext _context; //this line is hard coded.
    public CrustRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Crust> Create(Func<Crust, bool> filter)//Select
    {
      return _context.Crusts.Where(filter);
    }
    public bool Update(Crust entry)//Insert
    {
      throw new System.NotImplementedException();
    }
    public Crust Read()//Update
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}