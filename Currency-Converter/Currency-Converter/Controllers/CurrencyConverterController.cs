using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class CurrencyConverterController : Controller
{
    private readonly HttpClient _client;

    public CurrencyConverterController(IHttpClientFactory httpClientFactory)
    {
        _client = httpClientFactory.CreateClient();
    }

    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Convert(CurrencyConverterModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", model);
        }

        double conversionRate = await GetConversionRateAsync(model.FromCurrency, model.ToCurrency);

        if (conversionRate != 0)
        {
            double convertedAmount = model.Amount * conversionRate;
            ViewBag.ConvertedAmount = convertedAmount.ToString("0.00");
        }
        else
        {
            ViewBag.Error = "Conversion rate not available for the selected currencies.";
        }

        return View("Index", model);
    }

    private async Task<double> GetConversionRateAsync(string fromCurrency, string toCurrency)
    {
        string apiKey = "YOUR_API_KEY";
        string url = $"https://open.er-api.com/v6/latest/{fromCurrency}";

        HttpResponseMessage response = await _client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            JObject exchangeRates = JObject.Parse(json);

            if (exchangeRates.ContainsKey("rates") && exchangeRates["rates"].ToObject<JObject>().ContainsKey(toCurrency))
            {
                return exchangeRates["rates"][toCurrency].Value<double>();
            }
        }

        return 0;
    }
}