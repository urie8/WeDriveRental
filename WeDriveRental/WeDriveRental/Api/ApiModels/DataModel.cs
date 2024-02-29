using Newtonsoft.Json;

namespace WeDriveRental.Api.ApiModels
{
    public class CurrencyModel
    {
        [JsonProperty("EUR")]
        public double? EUR { get; set; }

        [JsonProperty("SEK")]
        public int? SEK { get; set; }

        [JsonProperty("USD")]
        public double? USD { get; set; }
    }
}
