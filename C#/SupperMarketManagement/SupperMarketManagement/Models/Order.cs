using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperMarketManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string DateCreate { get; set; }
        public string TotalAmount { get; set; }
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
