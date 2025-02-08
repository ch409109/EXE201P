using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Admin.Voucher
{
    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public IndexModel(ClickCartDbContext context)
        {
            _context = context;
        }

        public IReadOnlyList<Models.Voucher> Vouchers { get; set; }
        public int TotalItems { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public const int PageSize = 5;

        [BindProperty]
        public Models.Voucher NewVoucher { get; set; }
        [BindProperty]
        public int EditVoucherID { get; set; }
        [BindProperty]
        public List<int> SelectedVoucherIDs { get; set; }
        public async Task<IActionResult> OnGetAsync(int? pageNumber)
        {
            if (_context.Vouchers != null)
            {
                TotalItems = await _context.Vouchers.CountAsync();

                PageNumber = pageNumber ?? 1;

                TotalPages = (int)Math.Ceiling(TotalItems / (double)PageSize);

                Vouchers = await _context.Vouchers
                    .OrderBy(v => v.VoucherID)
                    .Skip((PageNumber - 1) * PageSize)     
                    .Take(PageSize)
                    .ToListAsync();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            if (ModelState.IsValid)
            {
                _context.Vouchers.Add(NewVoucher);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }    

        public async Task<IActionResult> OnPostEditAsync()
        {
            var voucher = await _context.Vouchers.FindAsync(EditVoucherID);
            if (voucher != null)
            {
                voucher.VoucherCode = Request.Form["VoucherCode"];
                voucher.DiscountPercentage = int.Parse(Request.Form["DiscountPercentage"]);
                voucher.StartDate = DateTime.Parse(Request.Form["StartDate"]);
                voucher.EndDate = DateTime.Parse(Request.Form["EndDate"]);

                await _context.SaveChangesAsync();
                return RedirectToPage();
            }

            ModelState.AddModelError(string.Empty, "Voucher not found.");
            return Page();
        }


        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher != null)
            {
                _context.Vouchers.Remove(voucher);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteSelectedAsync(string selectedIds)
        {
            if (!string.IsNullOrEmpty(selectedIds))
            {
                var ids = selectedIds.Split(',').Select(int.Parse).ToList();

                var vouchersToDelete = await _context.Vouchers
                    .Where(v => ids.Contains(v.VoucherID))
                    .ToListAsync();

                if (vouchersToDelete.Any())
                {
                    _context.Vouchers.RemoveRange(vouchersToDelete);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToPage();
        }

    }
}
