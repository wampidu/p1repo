using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class PizzaModel : AModel
  {
    public CrustModel Crust { get; set; }
    public SizeModel Size { get; set; }
    public List<ToppingModel> Toppings { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
      string p = $"{Name}, {Crust}, {Size}";
      return p;
    
    }
    public PizzaModel()
    {
      
    }

    public PizzaModel(CrustModel c, SizeModel s, List<ToppingModel> t)
    {
      Crust = c;
      Size = s;
      Toppings = t;
    }

  }
}
