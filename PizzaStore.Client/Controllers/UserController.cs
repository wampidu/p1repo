using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PizzaStore.Client.Models;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
  //[Route("/user")]
    public class UserController : Controller
    {
      private readonly PizzaStoreDbContext _db;

      public UserController(PizzaStoreDbContext dbContext) //constructor dependency injection
      {
        _db = dbContext;
      }
      
      [HttpPost]
      [Route("/user")]
      public IActionResult Home(UserViewModel user)
      {
        return View("User", user);
      }

      [Route("/user/summary")]
      public IActionResult Summary(PizzaViewModel model)
      {
        // return View("Summary");
        // string connectionString = "<THE CONNECTION STRING HERE>";
        // string sql = "SELECT * FROM students";
        // SqlConnection conn = new SqlConnection(connectionString);
        // SqlCommand cmd = new SqlCommand(sql, conn);

        // var model = new List<PizzaModel>();
        // using(conn)
        // {
        //   conn.Open();
        //   SqlDataReader rdr = cmd.ExecuteReader();
        //   while(rdr.Read())
        //   {
        //     var pizza = new PizzaModel();
        //     pizza.Size = rdr["Size"];
        //     pizza.Crust = rdr["Crust"];
        //     foreach (var t in pizza.Toppings)
        //     {
        //       pizza.Toppings = pizza.Toppings.Add(rdr["Topings"]);
        //     }
        //     model.Add(pizza);
        //   }
        // }
        return View("Summary", model);
      }




      // [HttpGet()]
      // public IEnumerable<UserModel> Get()
      // {
      //   return _db.Users.ToList();
      // }
      
      // [HttpGet("{id}")]
      // public UserModel Get(int id)
      // {
      //   return _db.Users.SingleOrDefault(p => p.Id == id);
      // }

      //
    }
}