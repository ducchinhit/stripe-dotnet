namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardCreateOptions : BaseOptions
    {
        [JsonProperty("default_for_currency")]
        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public CardCreateNestedOptions SourceCard { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
