using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Models
{
    public class OrderViewModel : IValidatableObject
    {
        public List<string> Crusts { get; set; }
        public List<string> Sizes { get; set; }
        public List<string> Toppings { get; set; }
        // = new List<string> { "Original", "Stuffed Crust", "Pretzel" };
        // = new List<string> {"Small", "Medium","Large"};
        // = new List<string> {"Nara", "Mozz", "Basil", "Pep", "Saus"};
        
        [Required(ErrorMessage = "* SELEC UR CRUST")] // if selectedcrust is null
        [DataType(DataType.Text)]
        public string SelectedCrust { get; set; }
        
        [Required(ErrorMessage = "* SELEC UR SIZE")]
        [DataType(DataType.Text)]
        public string SelectedSize { get; set; }
        
        [Required(ErrorMessage = "* SELEC UR TOPS")]
        public List<string> SelectedToppings { get; set; }

        public OrderViewModel(UnitOfWork unitOfWork)
        {
            Crusts = unitOfWork.Crusts.Create().ToList();
            Sizes = unitOfWork.Sizes.Create().ToList();
            Toppings = unitOfWork.Toppings.Create().ToList();
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
            if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
            {
            yield return new ValidationResult("no good toppings, try ", new[] { "SelectedToppings" });
            }
        }
    }
}