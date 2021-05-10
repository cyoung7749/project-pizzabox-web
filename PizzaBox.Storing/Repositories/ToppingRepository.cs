using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context; //this line is hard coded.
    public delegate bool ToppingDelegate(Topping topping);
    public ToppingRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Topping> Create(Func<Topping, bool> filter)//Select
    {
      return _context.Toppings.Where(filter);//ToppingDelegate 
    }
    public bool Update(Topping entry)//Insert
    {
      throw new System.NotImplementedException();
    }
    public Topping Read()//Update
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}