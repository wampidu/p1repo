using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Controllers
{
    public class UserController : Controller
    {
      private readonly PizzaStoreDbContext _db;

      public UserController(PizzaStoreDbContext dbContext) //constructor dependency injection
      {
        _db = dbContext;
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