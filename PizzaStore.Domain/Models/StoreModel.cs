using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class StoreModel : AModel
  {
    public List<OrderModel> Orders { get; set; }

    public override string ToString()
    {
      string StoreName = $"{Name}";
      return StoreName;
    }
  }
}
