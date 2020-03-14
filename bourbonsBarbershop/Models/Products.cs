using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bourbonsBarbershop.Models
{
    public class Products
    {
        public int ProductId { get; set; }

        public string ProductType { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
