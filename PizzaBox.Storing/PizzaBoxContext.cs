// ENTITY FRAME GOES HERE
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using System.Linq;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);

      OnDataSeeding(builder);
    }
    private void OnDataSeeding(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new[]
     {
              new Crust() { EntityId = 1, Name = "Thin", Price = 2.00M},
              new Crust() { EntityId = 2, Name = "Original", Price = 3.00M},
              new Crust() { EntityId = 3, Name = "Thick", Price = 4.00M}
     });
      builder.Entity<Size>().HasData(new[]
      {
              new Size() { EntityId = 1, Name = "Small", Price = 4.00M},
              new Size() { EntityId = 2, Name = "Medium", Price = 6.00M},
              new Size() { EntityId = 3, Name = "Large", Price = 8.00M}
      });
      builder.Entity<Topping>().HasData(new[]
      {
              new Topping() { EntityId = 1, Name = "Marinara", Price = 2.00M},
              new Topping() { EntityId = 2, Name = "Mozzarella", Price = 2.00M},
              new Topping() { EntityId = 3, Name = "Basil", Price = 2.00M},
              new Topping() { EntityId = 4, Name = "Pepperoni", Price = 3.00M},
              new Topping() { EntityId = 5, Name = "Sausage", Price = 3.00M},
              new Topping() { EntityId = 6, Name = "Parmesan", Price = 1.00M},
              new Topping() { EntityId = 7, Name = "Fresh Mozzarella", Price = 2.00M},
              new Topping() { EntityId = 8, Name = "Mushrooms", Price = 2.00M}
      });
    }
  }
}