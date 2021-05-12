using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/order")]
  public class OrderController : Controller
  {
    public readonly UnitOfWork _unitOfWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitOfWork.Crusts.Create(c => c.Name == order.SelectedCrust).First();
        var size = _unitOfWork.Sizes.Create(s => s.Name == order.SelectedSize).First();
        var toppings = new List<Topping>();
        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Toppings.Create(t => t.Name == item).First());
        }

        var newPizza = new Pizza { Crust = crust, Size = size, Toppings = toppings };
        var newOrder = new Order { Pizzas = new List<Pizza> { newPizza } };

        //no longer _unitOfWork.Save();
        var TTotal = toppings.Sum(x => x.Price);
        var PizzaCost = newPizza.Crust.Price + newPizza.Size.Price + TTotal;
        ViewBag.Total = PizzaCost;

        _unitOfWork.Orders.Update(newOrder);
        ViewBag.Order = newOrder;
        return RedirectToAction("Home/Customer"); //change this later 
      }
      order.Load(_unitOfWork);
      return View("Order", order); //data binding
    }
    //public IActionResult Customer() in HOME
    //{
    //  return View("Checkout");
    //}
  }
}