using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {  
    IEnumerable<T> Create(); //Select
    bool Update(); //Insert
    T Read(); //Update
    bool Delete();
    }
}