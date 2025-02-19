using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClickCart.Pages
{
    public class StepOneModel : PageModel
    {
        public void OnGet()
        {
			var cartID = HttpContext.Session.GetInt32("CartID");

		}
	}
}
