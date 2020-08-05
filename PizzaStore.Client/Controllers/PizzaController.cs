using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
    public class PizzaController : Controller
    {
      private readonly PizzaStoreDbContext _db;

      public PizzaController(PizzaStoreDbContext dbContext) //constructor dependency injection
      {
        _db = dbContext;
      }
                   //                       listed in order of operation
      [HttpGet()] //action filters (authorization/authentication filters, action, resource, response, exception)
      public IActionResult Get()
      {
        //ViewData, TempData (dictionaries)
        //ViewBag.PizzaList = _db.Pizzas.ToList(); //dynamic object

        return View("Home2", _db.Pizzas.ToList());
      }
      
      [HttpGet("{id}")]
      public PizzaModel Get(int id)
      {
        return _db.Pizzas.SingleOrDefault(p => p.Id == id);
      }
    }
}