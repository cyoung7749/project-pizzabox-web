using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    IEnumerable<T> Create(Func<T, bool> filter); //Select
    bool Update(T entry); //Insert
    T Read(); //Update
    bool Delete();
  }
}