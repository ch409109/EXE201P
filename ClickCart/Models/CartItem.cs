using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class CartItem
	{
		[Key]
		public int CartItemID { get; set; }

		[Required, ForeignKey("Cart")]
		public int CartID { get; set; }

		[Required, ForeignKey("Product")]
		public int ProductID { get; set; }

		[Required]
		public int Quantity { get; set; }
		public string? Note { get; set; } = null;

		public Cart Cart { get; set; }
		public Product Product { get; set; }
	}
}
