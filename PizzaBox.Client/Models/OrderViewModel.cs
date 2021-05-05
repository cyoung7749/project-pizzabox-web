using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
    public class OrderViewModel
    {
        public List<string> Crusts { get; set; } = new List<string> { "Original", "Stuffed Crust", "Pretzel" };
        public List<string> Sizes { get; set; }
        public List<string> Toppings { get; set; }
        [Required] // if selectedcrust is null
        public string SelectedCrust { get; set; }
        [Required]
        public string SelectedSize { get; set; }
        public List<string> SelectedToppings { get; set; }

    }
}