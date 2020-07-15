using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ARMDataManager.Library.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Discription { get; set; }
        public decimal RetailPrice { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsTaxable { get; set; }      
    }
}
