using System.Collections.Generic;
using System.Linq;
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
        return View("Checkout"); //change this later 
      }
      order.Load(_unitOfWork);
      return View("Order", order); //data binding
    }
  }
}