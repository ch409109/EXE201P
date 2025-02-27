using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ClickCart.Pages.Admin.Products
{


	public class IndexModel : PageModel
	{
		private readonly ClickCartDbContext _context;
		private readonly IWebHostEnvironment _env;

		public IndexModel(ClickCartDbContext context, IWebHostEnvironment env)
		{
			_context = context;
			_env = env;
		}


		private const int PageSize = 10;

		public List<Product> Products { get; set; } = new List<Product>();
		public List<Category> Categories { get; set; } = new List<Category>();
		[BindProperty] public Product NewProduct { get; set; } = new Product();
		[BindProperty] public Product EditProduct { get; set; } = new Product();
		public int PageNumber { get; set; } = 1;
		public int TotalPages { get; set; }
		public int TotalItems { get; set; }
		private int GetUserId()
		{
			return int.TryParse(User.FindFirstValue("UserId"), out var userId) ? userId : 0;
		}

		public async Task<IActionResult> OnGetAsync(int pageNumber = 1)
		{
			string userRole = User.FindFirstValue(ClaimTypes.Role);
			var userId = GetUserId();
			if (userRole == null || !userRole.Equals("Admin") || userId == 0)
			{
				return RedirectToPage("/Login");

			}
			Categories = _context.Categories.ToList();
			const int pageSize = 10;
			var query = _context.Products.Include(p => p.Category).AsQueryable();
			TotalItems = await query.CountAsync();
			TotalPages = (int)Math.Ceiling(TotalItems / (double)pageSize);
			Products = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
			PageNumber = pageNumber;
			return Page();
		}

		public async Task<IActionResult> OnPostAddAsync()
		{
			string userRole = User.FindFirstValue(ClaimTypes.Role);
			var userId = GetUserId();
			if (userRole == null || !userRole.Equals("Admin") || userId == 0)
			{
				return RedirectToPage("/Login");
			}
            int increasedPrice = (int)Math.Round(NewProduct.Price * 1.1 / 1000) * 1000;
            NewProduct.Price = increasedPrice;
            _context.Products.Add(NewProduct);
			var uploadedFile = Request.Form.Files.FirstOrDefault();
			if (uploadedFile != null)
			{
				var category = await _context.Categories.FindAsync(NewProduct.CategoryID);
				if (category == null)
				{
					ModelState.AddModelError("", "Category not found");
					return Page();
				}
				string categoryFolder;
				switch (category.CategoryName)
				{
					case "Đồ ăn vặt":
						categoryFolder = "Do_An_Vat";
						break;
					case "Gia vị":
						categoryFolder = "Gia_Vi";
						break;
					case "Nước giải khát":
						categoryFolder = "Nuoc_Giai_Khat";
						break;
					case "Thực phẩm ăn liền":
						categoryFolder = "Thuc_Pham_An_Lien";
						break;
					case "Thực phẩm tươi sống":
						categoryFolder = "Thuc_Pham_Tuoi_Song";
						break;
					case "Dụng cụ nhà bếp":
						categoryFolder = "Dung_Cu_Nha_Bep";
						break;
					default:
						categoryFolder = category.CategoryName.Replace(" ", "_");
						break;
				}
				var uploadPath = Path.Combine(_env.WebRootPath, "common", "images", "products", categoryFolder);
				Directory.CreateDirectory(uploadPath);  

				var fileName = NewProduct.ProductName + Path.GetExtension(uploadedFile.FileName);
				var filePath = Path.Combine(uploadPath, fileName);
				if (!System.IO.File.Exists(filePath))
				{
					using (var stream = new FileStream(filePath, FileMode.Create))
					{
						await uploadedFile.CopyToAsync(stream);
					}
				}
				NewProduct.ImageUrl = Path.Combine(categoryFolder, fileName);
			}

			await _context.SaveChangesAsync();
			return RedirectToPage(new { pageNumber = PageNumber });
		}

		public async Task<IActionResult> OnPostEditAsync()
		{
			string userRole = User.FindFirstValue(ClaimTypes.Role);
			var userId = GetUserId();
			if (userRole == null || !userRole.Equals("Admin") || userId == 0)
			{
				return RedirectToPage("/Login");
			}

			var product = await _context.Products.FindAsync(EditProduct.ProductID);

			if (product != null)
			{
				product.ProductName = EditProduct.ProductName;
				product.Price = EditProduct.Price;
				product.Stock = EditProduct.Stock;
				product.Description = EditProduct.Description;
				product.CategoryID = EditProduct.CategoryID;
				var uploadedFile = Request.Form.Files.FirstOrDefault();
				if (uploadedFile != null)
				{
					var category = await _context.Categories.FindAsync(EditProduct.CategoryID);
					if (category == null)
					{
						ModelState.AddModelError("", "Category not found");
						return Page();
					}
					string categoryFolder;
					switch (category.CategoryName)
					{
						case "Đồ ăn vặt":
							categoryFolder = "Do_An_Vat";
							break;
						case "Gia vị":
							categoryFolder = "Gia_Vi";
							break;
						case "Nước giải khát":
							categoryFolder = "Nuoc_Giai_Khat";
							break;
						case "Thực phẩm ăn liền":
							categoryFolder = "Thuc_Pham_An_Lien";
							break;
						case "Thực phẩm tươi sống":
							categoryFolder = "Thuc_Pham_Tuoi_Song";
							break;
						case "Dụng cụ nhà bếp":
							categoryFolder = "Dung_Cu_Nha_Bep";
							break;
						default:
							categoryFolder = category.CategoryName.Replace(" ", "_");
							break;
					}
					var uploadPath = Path.Combine(_env.WebRootPath, "common", "images", "products", categoryFolder);
					Directory.CreateDirectory(uploadPath);  
					var fileName = EditProduct.ProductName + Path.GetExtension(uploadedFile.FileName);
					var filePath = Path.Combine(uploadPath, fileName);
					if (!System.IO.File.Exists(filePath))
					{
						using (var stream = new FileStream(filePath, FileMode.Create))
						{
							await uploadedFile.CopyToAsync(stream);
						}
					}
					product.ImageUrl = Path.Combine(categoryFolder, fileName);
				}
				await _context.SaveChangesAsync();
			}
			return RedirectToPage(new { pageNumber = PageNumber });
		}

		public async Task<IActionResult> OnPostDeleteAsync(int id)
		{
			string userRole = User.FindFirstValue(ClaimTypes.Role);
			var userId = GetUserId();
			if (userRole == null || !userRole.Equals("Admin") || userId == 0)
			{
				return RedirectToPage("/Login");

			}
			var product = await _context.Products.FindAsync(id);
			if (product != null)
			{
				_context.Products.Remove(product);
				await _context.SaveChangesAsync();
			}
			return RedirectToPage(new { pageNumber = PageNumber });
		}
	}

}
