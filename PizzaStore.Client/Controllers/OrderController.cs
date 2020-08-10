using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
  //[Route("/order")] //either use CONTROLLER ROUTING or GLOBAL ROUTING {[NOT BOTH]}
  //[EnableCors("private")] //CORS is not a P1 req, dont stress on it
    public class OrderController : Controller
    {
      private readonly PizzaStoreDbContext _db;

      public OrderController(PizzaStoreDbContext dbContext) //constructor dependency injection
      {
        _db = dbContext;
      }

      //Route("/home")]
      [HttpPost]
      [Route("/order/custom")]
      public IActionResult Custom(UserViewModel userViewModel)
      {
        ViewBag.UserName = userViewModel.Name;
        return View("Custom", new PizzaViewModel(_db));
      }

      [HttpPost]
      [Route("/order/preset")]
      public IActionResult Preset(UserViewModel userViewModel)
      {
        ViewBag.Sizes = _db.Sizes.ToList();
        ViewBag.Crusts = _db.Crusts.ToList();
        ViewBag.Toppings = _db.Toppings.ToList();
        ViewBag.Order = new OrderModel();
        ViewBag.Pizza = new PizzaModel();
        return View("Preset", new OrderViewModel());
      }

      [HttpPost]
      [Route("/order/placeorder")]
      //[ValidateAntiForgeryToken]
      public IActionResult PlaceOrder(OrderViewModel orderViewModel) //model binding
      {
        if (ModelState.IsValid) //validating that the requirements in PizzaViewModel are being met
        {
          return RedirectToAction("Summary", "User", orderViewModel);//http 300-series status //should probably redirect to a user/cart/ or something like that
        }
        return View("MainOrder");
      }

      [HttpPost]
      [Route("/order")]
      public IActionResult Main(UserViewModel userViewModel)
      {

        ViewBag.UserId = userViewModel.ID;
        ViewBag.UserName = userViewModel.Name;
        var users = _db.Users.ToList();
        for(int i = 0; i < users.Count(); i++)
        {
          if(userViewModel.Name == users[i].Name)
          {
            return View("MainOrder", new UserViewModel(){Name = userViewModel.Name});
          }
        }
        _db.Users.Add(new UserModel(){Name = userViewModel.Name, Id = userViewModel.ID});
        _db.SaveChanges();
        return View("MainOrder", userViewModel);
      }
      /*
      http status
       - 100-series = network
       - 200-series = all is well/good, 200-ok, 201-modified, 202-notmodified
       - 300-series = redirection, temporary or permanent
       - 400-series = user is stupid // errors on user end
       - 500-series = dev is stupid // errors on dev end

        //  CrustModel tempcrust = new CrustModel();
          //  tempcrust.Name = pizzaViewModel.Crust;
          //  _db.Crusts.Add(tempcrust);

          //  SizeModel tempsize = new SizeModel();
          //  tempsize.Name = pizzaViewModel.Size;
          //  _db.Sizes.Add(tempsize);

          // List<ToppingModel> temptoppings = new List<ToppingModel>();
          // for (var i = 0; i < pizzaViewModel.Toppings.Count(); i ++)
          // {
          //     temptoppings.Add(new ToppingModel(){Name=pizzaViewModel.Toppings[i].Name});
          //     _db.Toppings.Add(temptoppings[i]);
          // }
          //  _db.SaveChanges();
      */
    }
}