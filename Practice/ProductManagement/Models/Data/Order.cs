using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductManagement.Models.Data
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public virtual Customer Customerdetails { get; set; }
        public virtual List<Product> Productdetails { get; set; }
    }
}
