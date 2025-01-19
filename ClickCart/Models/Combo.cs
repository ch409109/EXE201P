using System;
using System.Collections.Generic;

namespace ClickCart.Models
{
    public partial class Combo
    {
        public Combo()
        {
            ComboProducts = new HashSet<ComboProduct>();
        }

        public int ComboId { get; set; }
        public string ComboName { get; set; } = null!;
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        public virtual ICollection<ComboProduct> ComboProducts { get; set; }
    }
}
