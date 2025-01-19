using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }

		[Required, MaxLength(100)]
		public string CategoryName { get; set; }

		[MaxLength(255)]
		public string Description { get; set; }

		public ICollection<Product> Products { get; set; }
	}
}
