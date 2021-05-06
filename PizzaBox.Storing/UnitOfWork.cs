using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
    public class UnitOfWork
    {
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingRepository Toppings { get; }

    public UnitOfWork()
    {
      Crusts = new CrustRepository();
      Sizes = new SizeRepository();
      Toppings = new ToppingRepository();
      // do the same for toppings 
    }
  }
}