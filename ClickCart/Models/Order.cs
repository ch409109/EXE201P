﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required, ForeignKey("User")]
        public int UserID { get; set; }

        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public string? FullName { get; set; } = " ";

        [Required, MaxLength(10)]
        [Phone]
        public string PhoneNumber { get; set; } = " ";

        [Required]
        public string ShippingAddress { get; set; }


        [Required, MaxLength(50)]
        public string PaymentStatus { get; set; }

        [Required, MaxLength(50)]
        public string PaymentGateway { get; set; }

        [Required]
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now.AddHours(7);

        public User User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
