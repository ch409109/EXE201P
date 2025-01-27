using ClickCart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClickCart.Pages.Admin.User
{
    public class IndexModel : PageModel
    {
        private readonly ClickCartDbContext _context;

        public IndexModel(ClickCartDbContext context)
        {
            _context = context;
        }

        public List<Models.User> Users { get; set; }
        public int TotalItems { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public const int PageSize = 5;

        public async Task OnGetAsync(int? pageNumber)
        {
            TotalItems = await _context.Users.CountAsync();
            PageNumber = pageNumber ?? 1;
            TotalPages = (int)Math.Ceiling(TotalItems / (double)PageSize);

            Users = await _context.Users
                .OrderBy(u => u.UserID)
                .Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostAddAsync(Models.User user)
        {
            if (ModelState.IsValid)
            {
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToPage();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostEditAsync(Models.User user)
        {
            var existingUser = await _context.Users.FindAsync(user.UserID);
            if (existingUser != null)
            {
                existingUser.Username = user.Username;
                existingUser.FullName = user.FullName;
                existingUser.Email = user.Email;
                existingUser.PhoneNumber = user.PhoneNumber;
                existingUser.Role = user.Role;

                await _context.SaveChangesAsync();
                return RedirectToPage();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int userID)
        {
            var user = await _context.Users.FindAsync(userID);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return RedirectToPage();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteSelectedAsync(string selectedIds)
        {
            if (!string.IsNullOrEmpty(selectedIds))
            {
                var ids = selectedIds.Split(',').Select(int.Parse).ToList();

                var usersToDelete = await _context.Users
                    .Where(u => ids.Contains(u.UserID))
                    .ToListAsync();

                if (usersToDelete.Any())
                {
                    _context.Users.RemoveRange(usersToDelete);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToPage();
        }

    }
}
