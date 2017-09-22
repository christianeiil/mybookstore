using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class AuthorModels
    {
        [Key]
        public int ID { get; set; }

        [Display (Name = "Last Name")]
        [MaxLength(40, ErrorMessage = "40 characters only")]
        [Required(ErrorMessage = "Required!")]
        public string LastName { get; set; }

        [Display (Name = "First Name")]
        [MaxLength(20, ErrorMessage = "20 characters only")]
        [Required(ErrorMessage = "Required!")]
        public string FirstName { get; set; }

        [Display (Name = "Phone")]
        [MaxLength(12, ErrorMessage = "Up to 12 digits only")]
        [Required(ErrorMessage = "Required!")]
        public string Phone { get; set; }

        [Display (Name = "Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(40, ErrorMessage = "40 characters only")]
        public string Address { get; set; }

        [Display (Name = "City")]
        [MaxLength(20, ErrorMessage = "20 characters only")]
        public string City { get; set; }

        [Display (Name = "State")]
        [MaxLength(2, ErrorMessage = "Invalid character length")]
        public string State { get; set; }

        [Display (Name = "Zipcode")]
        [MaxLength(5, ErrorMessage = "Invalid character length")]
        public string Zip { get; set; }
    }
}