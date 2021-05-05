using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  //[Route("[controller]")]
  public class OrderController : Controller
  {
    [HttpGet]
    [HttpPost]
    public string Ordaw(OrderViewModel order)
    {
      if (ModelState.IsValid)
      //{order != null & order.SelectedCrust != null}
      {
      return order.SelectedCrust;
      }
      return "no";
      //return null;
    }
  }
} 