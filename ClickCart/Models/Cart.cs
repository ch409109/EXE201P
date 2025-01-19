using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class Cart
	{
		[Key]
		public int CartID { get; set; }

		[Required, ForeignKey("User")]
		public int UserID { get; set; }

		public DateTime CreatedAt { get; set; } = DateTime.Now;

		public User User { get; set; }
		public ICollection<CartItem> CartItems { get; set; }
	}
}
