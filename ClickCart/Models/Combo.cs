using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class Combo
	{
		[Key]
		public int ComboID { get; set; }

		[Required, MaxLength(100)]
		public string ComboName { get; set; }

		[Required]
		public int Price { get; set; }
		[Required]

		public string Description { get; set; }

		public string ImageUrl { get; set; }
	}
}
