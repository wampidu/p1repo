using System;
using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class OrderModel : AModel
  {
    public List<PizzaModel> Pizzas { get; set; }
    public double OrderCost { get; set; }
    public int StoreID { get; set; }
    public int PizzaID { get; set; }
    public int UserID { get; set; }
    public DateTime Date { get; set; }

    public override string ToString()
    {
      string PizzaList = "";
      foreach(PizzaModel p in Pizzas)
      {
        PizzaList += $"{p.ToString()}, ";
      }
      return PizzaList;
    }
  }
}
