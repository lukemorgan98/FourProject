using BlazorShop.Shared;
using Stripe;
using Stripe.Checkout;
using System.Collections.Generic;

namespace BlazorShop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51KrkkkJgJuyHEOML5J8DuZ1YSjhrKnC35WXhJF3IryKAxnap1vfwBr7mSu7m0bkr880supQQQMe0GR1c4siEpDQe00C1jNHRQu";
        }

        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();
            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "usd", 
                    ProductData = new SessionLineItemPriceDataProductDataOptions {
                        Name = ci.ProductTitle,
                        Images = new List<string> {ci.Image }
                    }
                },
                Quantity = ci.Quantity
            }));


            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> 
                {
                    "card"
                },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:5001/order-success",
                CancelUrl = "https://localhost:5001/cart",
            };

            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }
    }
}
