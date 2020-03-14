using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bourbonsBarbershop.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        /// <summary>
        /// The users First Name
        /// </summary>
        [Required]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        /// <summary>
        /// The users last name
        /// </summary>
        [Required]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        /// <summary>
        /// Users E - Mail Address
        /// </summary>
        [Required]
        [Display(Name = "Email:")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// User Passwword
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Users Street Address
        /// </summary>
        
        [Display(Name = "Street Address:")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Users City
        /// </summary>
        [Display(Name = "City:")]
        public string City { get; set; }

        /// <summary>
        /// Users State
        /// </summary>
        [Display(Name = "State:")]
        public string State { get; set; }

        /// <summary>
        /// Users Street Address
        /// </summary>
        [Required]
        [Display(Name = "Phone Number:")]
        public string PhoneNumber { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
