using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Domain.Repositories
{
  public class SizeRepository: IRepository<Size>
  {
    public class IEnumberable<Crust> Create(){} //Select
    public class Crust Update(){} //Insert
    public class IEnumberable<Crust> Read(){} //Update
    public class Crust Delete(){}
  }
}