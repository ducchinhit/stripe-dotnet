namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsP24 : StripeEntity
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
