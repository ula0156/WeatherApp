﻿using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class DataService
    {
        public static async Task<dynamic> GetDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if (response != null && response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
 
            return data;
        }

    }
}
