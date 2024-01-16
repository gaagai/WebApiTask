using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShoppingListApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }
 
        public string FullName { get; set; }
        public string FullAddress { get; set; }
        public string Email { get; set; }
        public string OrderItemsJson { get; set; } 
    }
}