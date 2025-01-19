using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class OrderDetail
	{
		[Key]
		public int OrderDetailID { get; set; }

		[Required, ForeignKey("Order")]
		public int OrderID { get; set; }

		[Required, ForeignKey("Product")]
		public int ProductID { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		public int Price { get; set; }

		public Order Order { get; set; }

	}
}
