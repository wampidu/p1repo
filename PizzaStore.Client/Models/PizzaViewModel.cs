using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
  public class PizzaViewModel
  {
    //out to the client
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }
    public List<PizzaModel> Pizzas { get; set; }
// public List<CheckboxTopping> SelectedToppings2 { get; set; }
    // public PizzaViewModel(repository)
    // {
    //   Crusts = new List<CrustModel>() {new CrustModel};
    // }
    
    //in from the client
    [Required(ErrorMessage = "You must select a crust")]
    public string Crust { get; set; }

    [Required(ErrorMessage = "You must select a size")]
    public string Size { get; set; }

    //[Range(1,5)]
    // [MinLength(2)]
    // [MaxLength(5)]
    public List<ToppingModel> SelectedToppings { get; set; }
    //public int NumberOfToppings { get; set; }
    public bool SelectedTopping { get; set; }
    // public List<string> SelectedToppings2 { get; set; }
    

    public PizzaViewModel()
    {
      Crusts = new List<CrustModel>(){new CrustModel() {Name = "Chicago"}, new CrustModel(){Name = "Pan"}, new CrustModel(){Name = "Stuffed"} };
      Sizes = new List<SizeModel>(){new SizeModel(){Name = "Small"}, new SizeModel(){Name = "Medium"}, new SizeModel(){Name = "Large"}};
      Toppings = new List<ToppingModel>()
      {
        new ToppingModel(){Name = "Pepperoni"},
        new ToppingModel(){Name = "Ham"},
        new ToppingModel(){Name = "Sausage"},
        new ToppingModel(){Name = "Pineapple"},
        new ToppingModel(){Name = "Onion"},
        new ToppingModel(){Name = "Olives"}
      };
      SelectedToppings = new List<ToppingModel>();

      //PizzaFactory pizza = new PizzaFactory();
      //var p = new PizzaModel(Crusts[0], Sizes[0], Toppings);
      //SelectedToppings2 = new List<CheckboxToppings() {};
    }
  }
  
  public class CheckBoxTopping
  {
    public string Text { get; set; }

    public bool IsSelected { get; set; }
    
  }
}
