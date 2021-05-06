using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaBox.Client.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class HomeController : Controller 
  {
    private readonly UnitOfWork _unitOfWork = new UnitOfWork();
    
    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

  private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }    

    //If I wanted to use DIP, I'd have to do _unitOfWork = UnitOfWork;
    [HttpGet]
    public IActionResult Index()
    {
      //ViewBag.Order = new OrderViewModel();
      //return View("Index", new OrderViewModel()); //specify which view you want, cause this is just lucky that we found a "view"
      var view = View("Index", new OrderViewModel((_unitOfWork))); //add topping
      return view;
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
