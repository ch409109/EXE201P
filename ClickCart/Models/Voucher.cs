using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
	public class Voucher
	{
		[Key]
		public int VoucherID { get; set; }

		[Required, MaxLength(50)]
		public string VoucherCode { get; set; }

		[Required]
		public int DiscountPercentage { get; set; }

		[Required]
		public DateTime StartDate { get; set; }

		[Required]
		public DateTime EndDate { get; set; }

		public bool IsActive { get; set; } = true;
	}
}
