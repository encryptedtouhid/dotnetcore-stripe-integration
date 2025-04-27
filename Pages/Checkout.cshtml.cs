using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StripeIntegration.Models;
using StripeIntegration.Services;

namespace StripeIntegration.Pages;

public class CheckoutModel : PageModel
{
    private readonly StripeService _stripeService;
    private readonly IConfiguration _configuration;

    [BindProperty]
    public Order Order { get; set; } = new();

    public string PublishableKey { get; private set; }
    public string ClientSecret { get; private set; }

    public CheckoutModel(StripeService stripeService, IConfiguration configuration)
    {
        _stripeService = stripeService;
        _configuration = configuration;
        PublishableKey = _configuration["Stripe:PublishableKey"] ?? string.Empty;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var paymentIntent = await _stripeService.CreatePaymentIntentAsync(Order);
        ClientSecret = paymentIntent.ClientSecret;
        Order.PaymentIntentId = paymentIntent.Id;

        return Page();
    }
}