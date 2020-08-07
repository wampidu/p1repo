using System.Collections.Generic;

namespace PizzaStore.Domain.Factories
{
  public interface IFactory<T> where T : class, new()
  {
    T Create();
  }
  public interface IFactory2<T> : IFactory<T> where T: class, new() 
  {
    T Create(object a, object b, List<object> c);
  }
}
