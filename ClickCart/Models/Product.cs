using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class Product
	{
		[Key]
		public int ProductID { get; set; }

		[Required, MaxLength(100)]
		public string ProductName { get; set; }

		[Required, ForeignKey("Category")]
		public int CategoryID { get; set; }

		[Required]
		public int Price { get; set; } 

		[Required]
		public int Stock { get; set; }

		public string Description { get; set; }

		public string ImageUrl { get; set; }

		public bool IsAlcoholic { get; set; }

		public Category Category { get; set; }
	}
}
