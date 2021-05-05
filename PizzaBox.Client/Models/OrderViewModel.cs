using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
    public class OrderViewModel
    {
        public List<string> Crusts { get; set; }
        // = new List<string> { "Original", "Stuffed Crust", "Pretzel" };
        public List<string> Sizes { get; set; }
        // = new List<string> {"Small", "Medium","Large"};
        public List<string> Toppings { get; set; }
        // = new List<string> {"Nara", "Mozz", "Basil", "Pep", "Saus"};
        
        [Required(ErrorMessage = "* SELEC UR CRUST")] // if selectedcrust is null
        [DataType(DataType.Text)]
        public string SelectedCrust { get; set; }
        
        [Required(ErrorMessage = "* SELEC UR SIZE")]
        [DataType(DataType.Text)]
        public string SelectedSize { get; set; }
        
        [Required(ErrorMessage = "* SELEC UR TOPS")]
        //[Range(2,5)]
        public List<string> SelectedToppings { get; set; }

        public OrderViewModel(CrustRepository crustRepo, SizeRepository sizeRepo)
        {
            Crusts = crustRepo.Create().ToList();
            Sizes = sizeRepo.Create().ToList();
            //Toppings = toppingRepo.Create().ToList();
        }
        public IEnumerable<ValidationResult> Validate(ValidationResult validationContext)
        {
            //var validresults = new List<ValidationResult>();
            if (SelectedCrust == SelectedSize)
            {
/*          validresults.Add(new ValidationResult("crust goes on the outside, size ain't it chief",
                new string[] { "SelectedCrust", "SelectedSize"})); */
            // ^ always creates a list for validation
                yield return new ValidationResult("u wot");
            // this is the "lazy" method cause it only generates if the validation happens
            }
            /* yield return new ValidationResult("crust goes on the outside, size ain't it chief",
                new string[] { "SelectedCrust", "SelectedSize"}); */

            if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
            {
                yield return new ValidationResult("no good topping count");
            }
        }
    }
}