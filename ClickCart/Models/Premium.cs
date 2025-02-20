namespace ClickCart.Models
{
    public class Premium
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string PaymentStatus { get; set; } = "Pending";
        public string PremiumName { get; set; }
        public int Price { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
    }
}
