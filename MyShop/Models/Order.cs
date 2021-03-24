using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class Order
    {

        [BindNever]
        public int OrderId { get; set; }


        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your Postcode")]
        [StringLength(7, MinimumLength = 7)]
        [Display(Name = "PostCode")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Please enter your Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

       [BindNever]
        public decimal OrderTotal { get; set; }

        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}

