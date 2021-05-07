using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context; //this line is hard coded.
    public ToppingRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Topping> Create()
    {
      return _context.Toppings;
      //return new List<Topping> { new Topping(), new Topping(), new Topping() };
    } //Select
    public bool Update()
    {
      throw new System.NotImplementedException();
    } //Insert
    public Topping Read()
    {
      throw new System.NotImplementedException();
    } //Update
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}