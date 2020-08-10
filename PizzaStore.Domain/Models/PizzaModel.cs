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
      Crust = new CrustModel();
      Size = new SizeModel();
      Toppings = new List<ToppingModel>();
    }

    

  }
}
