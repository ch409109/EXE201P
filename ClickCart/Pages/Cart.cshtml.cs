using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;

namespace ClickCart.Pages
{
	public class CartModel : PageModel
	{
		private readonly ClickCartDbContext _context;

		public CartModel(ClickCartDbContext context) => _context = context;

		public List<CartItem> CartItems { get; set; }
		public decimal TotalPrice { get; set; }

		[BindProperty] public int ProductID { get; set; }
		[BindProperty] public int Quantity { get; set; }

		private int GetUserId()
		{
			return int.TryParse(User.FindFirstValue("UserId"), out var userId) ? userId : 0;
		}
		public async Task<IActionResult> OnGetAsync()
		{
			var userId = GetUserId();
			if (userId == 0)
			{
				return RedirectToPage("/Login");

			}
			var cart = await _context.Carts.Include(c => c.CartItems).ThenInclude(ci => ci.Product)
										   .FirstOrDefaultAsync(c => c.UserID == userId);

			CartItems = cart?.CartItems.ToList() ?? new List<CartItem>();
			TotalPrice = CartItems.Sum(ci => ci.Product.Price * ci.Quantity);
			return Page();
		}

		public async Task<IActionResult> OnGetAddToCartAsync(int? ProductID, int? Quantity)
		{
			var userId = GetUserId();
			if (userId == 0)
			{
				return new JsonResult(new { success = false, message = "Vui lòng đăng nhập để thêm vào giỏ hàng" });
			}

			// Nếu có ProductID trong QueryString thì thêm vào giỏ hàng
			if (ProductID.HasValue && Quantity.HasValue)
			{
				if (Quantity.Value <= 0 || Quantity.Value > 99)
				{
					TempData["Error"] = "Số lượng không hợp lệ!";
					return RedirectToPage();
				}

				var product = await _context.Products.FindAsync(ProductID.Value);
				if (product == null)
				{
					TempData["Error"] = "Sản phẩm không tồn tại!";
					return RedirectToPage();
				}

				var cart = await _context.Carts.Include(c => c.CartItems)
											   .FirstOrDefaultAsync(c => c.UserID == userId);
				if (cart == null)
				{
					cart = new Cart { UserID = userId, CartItems = new List<CartItem>() };
					_context.Carts.Add(cart);
				}

				var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductID == ProductID.Value);
				if (cartItem != null)
				{
					if (cartItem.Quantity + Quantity.Value > 99)
					{
						return new JsonResult(new { success = false, message = "Tổng số lượng không được vượt quá 99!" });
					}
					cartItem.Quantity += Quantity.Value;
				}
				else
				{
					cart.CartItems.Add(new CartItem { CartID = cart.CartID, ProductID = ProductID.Value, Quantity = Quantity.Value });
				}

				try
				{
					await _context.SaveChangesAsync();
					return new JsonResult(new { success = true, message = "Đã thêm sản phẩm vào giỏ hàng!" });
				}
				catch (Exception)
				{
					return new JsonResult(new { success = false, message = "Có lỗi xảy ra khi thêm vào giỏ hàng!" });
				}
			}

			// Hiển thị giỏ hàng như bình thường
			var cartData = await _context.Carts.Include(c => c.CartItems).ThenInclude(ci => ci.Product)
											   .FirstOrDefaultAsync(c => c.UserID == userId);
			CartItems = cartData?.CartItems.ToList() ?? new List<CartItem>();
			TotalPrice = CartItems.Sum(ci => ci.Product.Price * ci.Quantity);
			return Page();
		}

		public async Task<IActionResult> OnPostUpdateAsync(int cartItemId, int quantity)
		{
			var cartItem = await _context.CartItems.FindAsync(cartItemId);
			if (cartItem != null)
			{
				cartItem.Quantity = quantity;
				await _context.SaveChangesAsync();
			}
			return RedirectToPage();
		}

		public async Task<IActionResult> OnPostDeleteAsync(int cartItemId)
		{
			var cartItem = await _context.CartItems.FindAsync(cartItemId);
			if (cartItem != null)
			{
				_context.CartItems.Remove(cartItem);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage();
		}
	}
}
