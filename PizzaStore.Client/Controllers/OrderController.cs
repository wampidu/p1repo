using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
  [Route("/order")] //either use CONTROLLER ROUTING or GLOBAL ROUTING {[NOT BOTH]}
  //[EnableCors("private")] //CORS is not a P1 req, dont stress on it
    public class OrderController : Controller
    {
      private readonly PizzaStoreDbContext _db;

      public OrderController(PizzaStoreDbContext dbContext) //constructor dependency injection
      {
        _db = dbContext;
      }

      //[Route("/home")]
      public IActionResult Home()
      {
        return View("Order", new PizzaViewModel());
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public IActionResult PlaceOrder(PizzaViewModel pizzaViewModel) //model binding
      {
        if (ModelState.IsValid) //what is the validation (add to view model)
        {
          //var p = new PizzaFactory(); //use dependency injection
          // p.Create(pizzaViewModel);
          // repository.Create(pizzaViewModel);
          //return View("User"); //will look for a view labeled "USER" under the ORDER view folder, will then default to the "shared" views folder
          return Redirect("/user/cart");//http 300-series status //should probably redirect to a user/cart/ or something like that
        }
        return View("Order", pizzaViewModel);
      }
      /*
      http status
       - 100-series = network
       - 200-series = all is well/good, 200-ok, 201-modified, 202-notmodified
       - 300-series = redirection, temporary or permanent
       - 400-series = user is stupid // errors on user end
       - 500-series = dev is stupid // errors on dev end
      */
    }
}