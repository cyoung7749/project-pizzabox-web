using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  public class HomeController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    //If I wanted to use DIP, I'd have to do _unitOfWork = UnitOfWork;
    [HttpGet]
    public IActionResult Index()
    {
      return View("Index");
    }
    public IActionResult Privacy()
    {
      return View();
    }
    [HttpGet]
    public IActionResult Order()
    {
      var order = new OrderViewModel();
      order.Load(_unitOfWork);
      return View("Order", order);
      //same thing from order controller
    }
    public IActionResult History()
    {

      return View("History");
      //same thing from order controller
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
