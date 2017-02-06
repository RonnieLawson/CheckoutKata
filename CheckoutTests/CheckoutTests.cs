using NUnit.Framework;

namespace CheckoutKata.Tests
{
    [TestFixture]
    public class CheckoutKataTests
    {
        private static Checkout _checkout;
        private static PricingRules _pricingRules;

        [OneTimeSetUp]
        public void GivenACheckoutWithValidPricingRulesWhenCreatingTheCheckout()
        {
            _pricingRules = null;
            _checkout = new Checkout(_pricingRules);
        }

        [Test]
        public void ThenTheCheckoutIsCreated()
        {
            Assert.That(_checkout.GetType(), Is.EqualTo(typeof(Checkout)));
        }

        [Test]
        public void ThenThePriceingRulesAreStored()
        {
            var checkout = new Checkout(_pricingRules);
            Assert.That(checkout.PricingRules, Is.EqualTo(_pricingRules));
        }
    }
}
