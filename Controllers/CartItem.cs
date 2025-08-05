﻿using System.ComponentModel.DataAnnotations.Schema;

namespace InternTask2.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // Must exist
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual ApplicationUser User { get; set; }  // navigation property
        public virtual Product Product { get; set; }
        public decimal TotalPrice => Product != null ? Product.Price * Quantity : 0;

    }

}


