using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Models.Data
{
    public class Product
    {
        [Key]
        public string ProductName { get; set; }
        public int Price { get; set; }
        public virtual Order Orderdetails { get; set; }
    }
}
