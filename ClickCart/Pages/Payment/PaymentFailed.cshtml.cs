using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClickCart.Pages.Payment
{
    public class PaymentFailedModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PaymentFailedModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //public IActionResult OnGetTryAgain()
        //{
        //    //return RedirectToPage("/Seat/BookSeat");
        //}
    }
}
