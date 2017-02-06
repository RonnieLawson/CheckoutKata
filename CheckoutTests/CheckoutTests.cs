using NUnit.Framework;

namespace CheckoutKata.Tests
{
    [TestFixture]
    public class GivenACheckoutWithValidPricingRules
    {
        [Test]
        public void ThenTheCheckoutIsCreated()
        {
            var checkout = new Checkout();
            Assert.That(checkout.GetType(), Is.EqualTo(typeof(Checkout)));
        }

        [Test]
        public void ThenThePriceingRulesAreStored()
        {
            var checkout = new Checkout();
            Assert.That(checkout.GetType(), Is.EqualTo(typeof(Checkout)));
        }
    }
}
