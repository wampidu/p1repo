using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class OrderModel : AModel
  {
    public List<PizzaModel> Pizzas { get; set; }

    public double OrderCost { get; set; }

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
