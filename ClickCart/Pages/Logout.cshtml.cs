﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClickCart.Pages
{
	public class LogoutModel : PageModel
	{
		public async Task<IActionResult> OnGetAsync()
		{
			await HttpContext.SignOutAsync();

			return RedirectToPage("/Login");
		}
	}
}
