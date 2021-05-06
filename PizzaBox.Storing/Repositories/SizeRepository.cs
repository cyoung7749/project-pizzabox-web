using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Domain.Repositories
{
  public class SizeRepository: IRepository<Size>
  {
    public IEnumerable<Size> Create()
    {
            throw new System.NotImplementedException();
    } //Select
    public bool Update()
    {
            throw new System.NotImplementedException();
    } //Insert
    public Size Read()
    {
            throw new System.NotImplementedException();
    } //Update
    public bool Delete()
    {
            throw new System.NotImplementedException();
    }
  }
}