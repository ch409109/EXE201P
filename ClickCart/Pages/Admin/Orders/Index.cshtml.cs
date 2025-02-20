using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClickCart.Models;
using ClickCart.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClickCart.Pages.Admin.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public IndexModel(ClickCartDbContext context)
        {
            _context = context;
        }

        public IList<Order> Orders { get; set; } = new List<Order>();

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders
                .Include(o => o.User)
                .OrderByDescending(o => o.CreatedAt)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostUpdateStatusAsync([FromBody] UpdateStatusModel model)
        {
            try
            {
                var order = await _context.Orders.FindAsync(model.OrderId);
                if (order == null)
                {
                    return new JsonResult(new { success = false, message = "Không tìm th?y ??n hàng" });
                }

                order.Status = model.NewStatus;
                await _context.SaveChangesAsync();
                return new JsonResult(new { success = true });
            }
            catch (Exception ex)
            {
                // Log exception
                return new JsonResult(new { success = false, message = ex.Message });
            }
        }

        public class UpdateStatusModel
        {
            public int OrderId { get; set; }
            public string NewStatus { get; set; }
        }
    }
}