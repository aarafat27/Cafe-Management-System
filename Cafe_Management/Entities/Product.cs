using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Entities
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Double Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
