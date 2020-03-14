using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bourbonsBarbershop.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        /// <summary>
        /// The Product Type (gel, hairspray, pomade)
        /// </summary>
        [Required]
        [Display(Name = "Product Type (i.e. gel, pomade, hairspray):")]
        public string ProductType { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        [Required]
        [Display(Name = "Product Name:")]
        public string ProductName { get; set; }

        /// <summary>
        /// What does the product do?
        /// </summary>
        [Required]
        [Display(Name = "Product Description:")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// The price of the product
        /// </summary>
        [Required]
        [Display(Name = "Price:")]
        public decimal ProductPrice { get; set; }
    }
}
