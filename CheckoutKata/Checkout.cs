namespace CheckoutKata
{
    public class Checkout
    {
        public PricingRules PricingRules { get; }

        public Checkout(PricingRules pricingRules)
        {
            PricingRules = pricingRules;
        }
    }
}