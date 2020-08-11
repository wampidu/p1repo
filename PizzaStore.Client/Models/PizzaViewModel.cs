using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;
using PizzaStore.Storing;

namespace PizzaStore.Client.Models
{
  public class PizzaViewModel
  {
    //out to the client
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }
    public List<PizzaModel> Pizzas { get; set; }

    public string UserName { get; set; }
    public int UserID { get; set; }

    
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
    public List<ToppingModel> SelectedToppings2 { get; set; }
    public List<string> SelectedToppingString { get; set; }
    public string SelectedTopping { get; set; }
    

    public PizzaViewModel()
    {
      //use db to load in values initially
      //ex: _db = dbContext;
      //    Crusts = _db.Crusts.ToList();
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
      SelectedToppings2 = new List<ToppingModel>();
      SelectedToppingString = new List<string>();

      
    }
  }
  
  // public class CheckBoxToppingModel : AModel
  // {
  //   public bool IsSelected { get; set; }
  // }
}
