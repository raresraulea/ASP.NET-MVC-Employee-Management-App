using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You have to enter a valid EmployeeId")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You have to enter your First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You have to enter your Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You have to enter your Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Required(ErrorMessage = "You have to enter your Email Address")]
        [Compare(otherProperty: "EmailAddress", ErrorMessage = "Emails do not match")]
        public string ConfirmEmail { get; set; }

        [StringLength(100, MinimumLength = 10, ErrorMessage = "Provide a long enough password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
    
}