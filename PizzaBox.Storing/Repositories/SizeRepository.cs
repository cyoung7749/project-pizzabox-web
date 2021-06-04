using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storing.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;
    public SizeRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Size> Create(Func<Size, bool> filter)
    {
      return _context.Sizes.Where(filter);
      //return new List<Size> { new Size(), new Size() };
    } //Select
    public bool Update(Size entry)
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