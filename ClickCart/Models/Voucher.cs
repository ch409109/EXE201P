using System;
using System.Collections.Generic;

namespace ClickCart.Models
{
    public partial class Voucher
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; } = null!;
        public int DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
