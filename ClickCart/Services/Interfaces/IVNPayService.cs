using ClickCart.Models;

namespace ClickCart.Services.Interfaces
{
    public interface IVNPayService
    {
        string CreatePaymentUrl(PaymentInformation payment, string returnUrl);
        PaymentResponseModel PaymentExecute(IQueryCollection collections);
    }
}
