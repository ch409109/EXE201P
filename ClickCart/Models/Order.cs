using System;
using System.Collections.Generic;

namespace ClickCart.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int TotalAmount { get; set; }
        public string PaymentStatus { get; set; } = null!;
        public string PaymentGateway { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
