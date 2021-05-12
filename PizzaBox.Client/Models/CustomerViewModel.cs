using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Models
{
  public class CustomerViewModel : IValidatableObject
  {
    public IEnumerable<Customer> Customers { get; set; }

    [Required(ErrorMessage = "* who are you?")] // if selectedcrust is null
    [DataType(DataType.Text)]
    public string SelectedCustomer { get; set; }


    //we need orderviewmodel without unitofwork
    // using below, we won't need constructor since c# has implicit constructors
    public void Load(UnitOfWork unitOfWork)
    {
      Customers = unitOfWork.Customers.Create(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (SelectedCustomer == null)
      {
        yield return new ValidationResult("not a person try: ", new[] { "SelectedCustomer" });
      }
    }
  }
}