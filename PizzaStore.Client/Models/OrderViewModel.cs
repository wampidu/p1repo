using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
  public class OrderViewModel
  {

    public List<PizzaViewModel> Pizzas { get; set; }
    public int UserId { get; set; }
    public string UserName { get; set; }
    // public List<PizzaModel> Pizzas { get; set; }
    // public List<OrderModel> Orders { get; set;}
    // public double OrderCost { get; set; }
    // public int StoreID { get; set; }
    // public int PizzaID { get; set; }
    // public int UserID { get; set; }
    // public DateTime Date { get; set; }

    // public override string ToString()
    // {
    //   string PizzaList = "";
    //   foreach(PizzaModel p in Pizzas)
    //   {
    //     PizzaList += $"{p.ToString()}, ";
    //   }
    //   return PizzaList;
    // }
  }
}
