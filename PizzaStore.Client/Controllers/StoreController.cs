using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
  [Route("/store")]
    public class StoreController : Controller
    {
      // private readonly PizzaStoreDbContext _db;

      // public StoreController(PizzaStoreDbContext dbContext) //constructor dependency injection
      // {
      //   _db = dbContext;
      // }

      [Route("/store/home")]
      public IActionResult Home()
      {
        return View("Store");
      }
      // [HttpGet()]
      // public IEnumerable<StoreModel> Get()
      // {
      //   return _db.Stores.ToList();
      // }
      
      // [HttpGet("{id}")]
      // public StoreModel Get(int id)
      // {
      //   return _db.Stores.SingleOrDefault(p => p.Id == id);
      // }
    }
}