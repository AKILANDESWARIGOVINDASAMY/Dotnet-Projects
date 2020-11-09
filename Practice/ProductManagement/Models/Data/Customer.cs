using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Models.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }        
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public virtual List<Product> Productdetails { get; set; }
    }
}
