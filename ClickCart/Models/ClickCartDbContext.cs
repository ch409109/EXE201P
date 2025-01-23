using ClickCart.Data;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Models
{
	public class ClickCartDbContext : DbContext
	{
		public ClickCartDbContext(DbContextOptions<ClickCartDbContext> options) : base(options) { }
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Combo> Combos { get; set; }
		public DbSet<ComboProduct> ComboProducts { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Voucher> Vouchers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ComboProduct>().HasKey(cp => new { cp.ComboID, cp.ProductID });
			modelBuilder.Seed();
		}
	}
}
