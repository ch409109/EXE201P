using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class ComboProduct
	{
		[Required, ForeignKey("Combo")]
		public int ComboID { get; set; }

		[Required, ForeignKey("Product")]
		public int ProductID { get; set; }

		[Required]
		public int Quantity { get; set; }

		public Combo Combo { get; set; }
		public Product Product { get; set; }
	}
}
