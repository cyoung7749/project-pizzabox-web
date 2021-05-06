using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{

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
      return View("Checkout"); //change this later 
      } 
      order.Load(_unitOfWork);
      return View("Order", order); //data binding
    }
  }
} 