# ASP.NET Core Stripe Integration Example

This is a sample ASP.NET Core 8.0 web application demonstrating Stripe payment integration. The application shows how to process payments using Stripe Elements for a seamless checkout experience.

## Prerequisites

- .NET 8.0 SDK or later
- A Stripe account (you can create one at [stripe.com](https://stripe.com))
- Your Stripe API keys (available in your Stripe Dashboard)

## Setup Instructions

1. Clone this repository:
```bash
git clone https://github.com/encryptedtouhid/dotnetcore-stripe_integration.git
cd dotnetcore-stripe_integration
```

2. Update the Stripe configuration in `appsettings.json`:
   - Replace `your_stripe_secret_key` with your Stripe Secret Key
   - Replace `your_stripe_publishable_key` with your Stripe Publishable Key
   - Replace `your_stripe_webhook_secret` with your Stripe Webhook Secret (if using webhooks)

3. Restore dependencies and build the project:
```bash
dotnet restore
dotnet build
```

4. Run the application:
```bash
dotnet run
```

The application will start at `https://localhost:7234` (or a similar port).

## Features

- Simple checkout form with customer information
- Stripe Elements integration for secure card input
- Payment confirmation handling
- Basic error handling
- Responsive design using Bootstrap

## Project Structure

- `Pages/Checkout.cshtml`: Main checkout page with payment form
- `Pages/PaymentConfirmation.cshtml`: Payment confirmation page
- `Models/Order.cs`: Order model for payment processing
- `Services/StripeService.cs`: Service handling Stripe API interactions

## Testing

You can use Stripe's test cards to verify the integration:
- Success: 4242 4242 4242 4242
- Requires Authentication: 4000 0025 0000 3155
- Decline: 4000 0000 0000 9995

## Notes

- This is a basic implementation for demonstration purposes
- In a production environment, you should:
  - Add proper error handling
  - Implement webhook handling for asynchronous events
  - Add proper logging
  - Implement proper security measures
  - Store order information in a database

## Support

For any questions about:
- Stripe integration: [Stripe Documentation](https://stripe.com/docs)
- ASP.NET Core: [Microsoft Documentation](https://docs.microsoft.com/aspnet/core)
