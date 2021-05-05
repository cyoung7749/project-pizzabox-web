
namespace PizzaBox.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {  
    IEnumberable<T> Create(); //Select
    bool T Update(); //Insert
    IEnumberable<T> T Read(); //Update
    bool T Delete();
    }
}