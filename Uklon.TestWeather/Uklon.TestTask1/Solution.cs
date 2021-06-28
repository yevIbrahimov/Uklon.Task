using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Uklon.TestTask1
{
	public class Solution
	{
		private readonly HttpClient _client = new HttpClient();

		public async Task<(string, string)> GetTemperature()
		{
			var responseKyiv = await _client.GetAsync("https://goweather.herokuapp.com/weather/Kyiv");
			var contentKyiv = await responseKyiv.Content.ReadAsStringAsync();

			var responseOdesa = await _client.GetAsync("https://goweather.herokuapp.com/weather/Odesa");
			var contentOdesa = await responseOdesa.Content.ReadAsStringAsync();

			return (JObject.Parse(contentKyiv).SelectToken("$.temperature").ToString(),
					JObject.Parse(contentOdesa).SelectToken("$.temperature").ToString());

		}
	}
}
