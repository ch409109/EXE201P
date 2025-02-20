namespace ClickCart.Models
{
    public class Premium
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PaymentStatus { get; set; }
        public string PremiumName { get; set; }
        public int Price { get; set; }
    }
}
