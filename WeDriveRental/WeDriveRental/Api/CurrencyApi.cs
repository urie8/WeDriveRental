using Newtonsoft.Json;
using WeDriveRental.Api.ApiModels;

namespace WeDriveRental.Api
{
    public class CurrencyApi
    {
        private string apiKey = "fca_live_uOxCAKjsP8Lpb8J9Kn9VYC4jOPCBnox6qtMe2H1Y";
        public HttpClient Client { get; set; }
        public CurrencyApi()
        {
            Client = new();

            // Base adress with key
            Client.BaseAddress = new Uri("https://api.freecurrencyapi.com/v1/");
        }

        public async Task<CurrencyModel?> GetCurrenciesBaseSek()
        {
            HttpResponseMessage response = await Client.GetAsync($"latest?apikey={apiKey}&currencies=EUR%2CUSD%2CSEK&base_currency=SEK");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Root? currencies = JsonConvert.DeserializeObject<Root>(json);

                if (currencies != null)
                {
                    return currencies.Data;
                }
            }
            return null;
        }


    }
}
