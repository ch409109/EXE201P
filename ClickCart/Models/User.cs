using System.ComponentModel.DataAnnotations;

namespace ClickCart.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; }
        [Required]
        public int FreeShipCount { get; set; } = 0;
        public DateTime? PremiumStartDate { get; set; } = null;
        public DateTime? PremiumEndDate { get; set; } = null;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
