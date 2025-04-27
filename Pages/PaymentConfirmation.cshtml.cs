using Microsoft.AspNetCore.Mvc.RazorPages;
using StripeIntegration.Services;

namespace StripeIntegration.Pages;

public class PaymentConfirmationModel : PageModel
{
    private readonly StripeService _stripeService;
    public string PaymentStatus { get; private set; } = string.Empty;

    public PaymentConfirmationModel(StripeService stripeService)
    {
        _stripeService = stripeService;
    }

    public async Task OnGetAsync(string payment_intent)
    {
        if (string.IsNullOrEmpty(payment_intent))
        {
            PaymentStatus = "No payment information found.";
            return;
        }

        var paymentIntent = await _stripeService.GetPaymentIntentAsync(payment_intent);
        PaymentStatus = paymentIntent.Status;
    }
}