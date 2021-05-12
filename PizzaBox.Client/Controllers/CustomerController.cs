using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class CustomerController : Controller
  {
    public readonly UnitOfWork _unitOfWork;

    public CustomerController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Customer()
    {
      var order = new OrderViewModel();
      order.Load(_unitOfWork);
      return View("Checkout", order);  //take out the OrderViewModel
    }
    public IActionResult Create(CustomerViewModel order)
    {
      if (ModelState.IsValid)
      {
        var newCustomer = _unitOfWork.Customers.Create(c => c.Name == order.SelectedCustomer).First();
        var newOrder = new Order { Customers = newCustomer };

        _unitOfWork.Orders.Update(newOrder);
        _unitOfWork.Save();
        ViewBag.Order = newOrder;
        return View("Customer"); //change this later 
      }
      order.Load(_unitOfWork);
      return View("Checkout", order); //data binding
    }
  }
}