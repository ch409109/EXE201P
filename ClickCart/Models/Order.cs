using System.ComponentModel.DataAnnotations.Schema;
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

		[Required, MaxLength(50)]
		public string PaymentStatus { get; set; }

		[Required, MaxLength(50)]
		public string PaymentGateway { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.Now;

		public User User { get; set; }
		public ICollection<OrderDetail> OrderDetails { get; set; }
	}
}
