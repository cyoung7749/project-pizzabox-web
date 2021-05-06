using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  //[Route("/order/[controller]/[action]")]
  [Route("[controller]")]
  public class HomeController : Controller 
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    //If I wanted to use DIP, I'd have to do _unitOfWork = UnitOfWork;
    private static readonly UnitOfWork _unitOfWork = new UnitOfWork();
    [HttpGet]
    public IActionResult Index()
    {
      //ViewBag.Order = new OrderViewModel();
      //return View("Index", new OrderViewModel()); //specify which view you want, cause this is just lucky that we found a "view"
      var view = View("Index", new OrderViewModel((_unitOfWork))); //add topping
      return view;
    }
    public IActionResult Order()
    {
      return Order();
    }
    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
