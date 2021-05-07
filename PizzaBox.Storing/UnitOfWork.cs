using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingRepository Toppings { get; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;
      Crusts = new CrustRepository(_context);
      Sizes = new SizeRepository(_context);
      Toppings = new ToppingRepository(_context);  //
      // do the same for toppings 
    }
    public void Save()
    {
      _context.SaveChanges();
    }
  }
}