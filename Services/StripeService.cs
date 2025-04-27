using Stripe;
using StripeIntegration.Models;

namespace StripeIntegration.Services;

public class StripeService
{
    private readonly IConfiguration _configuration;

    public StripeService(IConfiguration configuration)
    {
        _configuration = configuration;
        StripeConfiguration.ApiKey = _configuration["Stripe:SecretKey"];
    }

    public async Task<PaymentIntent> CreatePaymentIntentAsync(Order order)
    {
        var options = new PaymentIntentCreateOptions
        {
            Amount = (long)(order.Amount * 100), // Convert to cents
            Currency = order.Currency,
            PaymentMethodTypes = new List<string> { "card" },
            Description = order.Description,
            ReceiptEmail = order.CustomerEmail
        };

        var service = new PaymentIntentService();
        return await service.CreateAsync(options);
    }

    public async Task<PaymentIntent> GetPaymentIntentAsync(string paymentIntentId)
    {
        var service = new PaymentIntentService();
        return await service.GetAsync(paymentIntentId);
    }
}