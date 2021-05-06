using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository: IRepository<Topping>
  {
    public IEnumerable<Topping> Create()
    {
        return new List<Topping> { new Topping(), new Topping(), new Topping() };
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