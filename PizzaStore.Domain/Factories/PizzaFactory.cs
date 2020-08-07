using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Domain.Factories
{
  public class PizzaFactory : IFactory<PizzaModel>
  {
    public PizzaModel Create()
    {
      var p = new PizzaModel();
      return p;
    }

    public PizzaModel CreateSpecific(CrustModel c, SizeModel s, List<ToppingModel> t)
    {
      var p = new PizzaModel(c, s, t);

      p.Crust = c;
      p.Size = s;
      p.Toppings = t;

      return p;
    }
  }
}
