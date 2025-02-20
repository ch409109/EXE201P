using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ClickCart.Pages.Admin.Premiums
{
    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public IndexModel(ClickCartDbContext context)
        {
            _context = context;
        }

        public List<Premium> Premiums { get; set; } = new List<Premium>();

        public async Task OnGetAsync()
        {
            Premiums = await _context.Premiums
                .Include(p => p.User)
                .OrderByDescending(p => p.PurchaseDate)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostUpdateStatusAsync([FromBody] UpdateStatusRequest request)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { success = false, message = "Dữ liệu không hợp lệ" });

                var premium = await _context.Premiums
                    .Include(p => p.User)
                    .FirstOrDefaultAsync(p => p.Id == request.PremiumId);

                if (premium == null)
                    return NotFound(new { success = false, message = "Không tìm thấy gói premium" });

                if (premium.User == null)
                    return BadRequest(new { success = false, message = "Người dùng không tồn tại" });

                var oldStatus = premium.PaymentStatus;
                premium.PaymentStatus = request.NewStatus;

                if (request.NewStatus == "Paid" && oldStatus != "Paid")
                {
                    premium.User.FreeShipCount = premium.PremiumName.Contains("Pro") ? 25 : 10;
                    premium.User.PremiumStartDate = DateTime.Now;
                    premium.User.PremiumEndDate = DateTime.Now.AddMonths(1);
                }
                else if (request.NewStatus == "Cancelled" && oldStatus == "Paid")
                {
                    premium.User.FreeShipCount = 0;
                    premium.User.PremiumStartDate = null;
                    premium.User.PremiumEndDate = null;
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return new JsonResult(new
                {
                    success = true,
                    newStatus = request.NewStatus,
                    statusBadge = GetStatusBadge(request.NewStatus),
                    statusText = GetStatusText(request.NewStatus)
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, new
                {
                    success = false,
                    message = $"Lỗi server: {ex.Message}"
                });
            }
        }

        private string GetStatusBadge(string status)
        {
            return status switch
            {
                "Paid" => "bg-success",
                "Pending" => "bg-warning",
                "Cancelled" => "bg-danger",
                _ => "bg-secondary"
            };
        }

        private string GetStatusText(string status)
        {
            return status switch
            {
                "Paid" => "Đã thanh toán",
                "Pending" => "Chờ thanh toán",
                "Cancelled" => "Đã hủy",
                _ => status
            };
        }

        public class UpdateStatusRequest
        {
            [Required]
            public int PremiumId { get; set; }

            [Required]
            [StringLength(20)]
            public string NewStatus { get; set; }
        }
    }
}
