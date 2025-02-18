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
        public int FreeShipCount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
