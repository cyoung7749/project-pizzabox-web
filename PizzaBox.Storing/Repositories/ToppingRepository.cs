using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Domain.Repositories
{
  public class ToppingRepository: IRepository<Topping>
  {
    public IEnumerable<Topping> Create()
    {
            throw new System.NotImplementedException();
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