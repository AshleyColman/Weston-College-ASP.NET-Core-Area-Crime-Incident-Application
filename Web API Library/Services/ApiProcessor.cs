using System.Net.Http.Headers;
using Web_API_Library.Models;

namespace Web_API_Library.Services
{
    public sealed class ApiProcessor : IApiProcessor
    {
        private readonly HttpClient client;

        public ApiProcessor()
        {
            client = new();
            client.BaseAddress = new Uri("https://data.police.uk/api/crimes-street/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<IEnumerable<CrimeIncidentModel>> LoadIncidents(double _latitude, double _longitude, string _date)
        {
            string url = $"all-crime?lat={_latitude}&lng={_longitude}&date={_date}";
            using HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode == true)
            {
                IEnumerable<CrimeIncidentModel> incidents = await response.Content.ReadAsAsync<IEnumerable<CrimeIncidentModel>>();
                return incidents;
            }
            else
            {
                return Enumerable.Empty<CrimeIncidentModel>();
                //throw new Exception($"{response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}
