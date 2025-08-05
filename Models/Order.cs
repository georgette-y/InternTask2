using System;

namespace InternTask2.Models
{
    public class Order
    {
        public int Id { get; set; }                  // Order ID
        public string CustomerName { get; set; }     // Who ordered
        public DateTime OrderDate { get; set; }      // When they ordered
        public decimal TotalAmount { get; set; }     // Total price
    }
}

