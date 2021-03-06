using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingRepository Toppings { get; }
    public OrderRepository Orders { get; set; }
    public PizzaRepository Pizzas { get; set; }
    public CustomerRepository Customers { get; set; }
    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;
      Crusts = new CrustRepository(_context);
      Sizes = new SizeRepository(_context);
      Toppings = new ToppingRepository(_context);
      Orders = new OrderRepository(_context);
      Pizzas = new PizzaRepository(_context);
      Customers = new CustomerRepository(_context);
    }
    public void Save()
    {
      _context.SaveChanges();
    }
  }
}