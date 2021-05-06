using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository: IRepository<Crust>
  {
    public IEnumerable<Crust> Create()
    {
        return new List<Crust> { new Crust(), new Crust() };
    } //Select
    public bool Update()
    {
        throw new System.NotImplementedException();
    } //Insert
    public Crust Read()
    {
        throw new System.NotImplementedException();
    } //Update
    public bool Delete()
    {
        throw new System.NotImplementedException();
    }
  }
}