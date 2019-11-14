using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assgn2.Models
{
    public class Person
    {

        [Display(Name = "Username")]
        [Required(ErrorMessage = "username must be entered")]
        [RegularExpression(@"^[A-Za-z0-9]{3,10}$", ErrorMessage = "Characters are not allowed.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "username must be between 3 - 10 characters long")]
        public string username { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "email address must be entered")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please input a valid email address")]
        public string email { get; set; }

        [Display(Name = "Mobile")]
        [Required(ErrorMessage = "mobile number must be entered")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a proper phone number")]
        public int mobile { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "date must be entered")]
        [DataType(DataType.DateTime, ErrorMessage = "Use proper date time")]
        public DateTime dob { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "city must be entered")]
        [RegularExpression(@"^[A-Za-z\s]{1,1000}$", ErrorMessage = "text only")]
        [DataType(DataType.Text)]
        public string city { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "country must be entered")]
        [RegularExpression(@"^[A-Za-z\s]{1,1000}$", ErrorMessage = "text only")]
        [DataType(DataType.Text)]
        public string country { get; set; }
    }
}