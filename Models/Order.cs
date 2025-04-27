namespace StripeIntegration.Models;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerEmail { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "usd";
    public string Description { get; set; } = string.Empty;
    public string PaymentIntentId { get; set; } = string.Empty;
    public string PaymentStatus { get; set; } = string.Empty;
}