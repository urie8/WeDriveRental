using Newtonsoft.Json;

namespace WeDriveRental.Api.ApiModels
{
    public class Root
    {
        [JsonProperty("data")]
        public CurrencyModel? Data { get; set; }
    }
}
