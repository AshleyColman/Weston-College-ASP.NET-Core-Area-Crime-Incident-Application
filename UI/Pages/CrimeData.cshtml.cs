using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_API_Library.Models;
using Web_API_Library.Services;

namespace UI.Pages
{
    public class CrimeDataModel : PageModel
    {
        private readonly IApiProcessor apiProcessor;

        [BindProperty]
        public QueryModel QueryModel { get; set; }
        public IQueryModel SampleQueryModel { get; set; } = new QueryModel
        {
            Latitude = 51.3509,
            Longitude = -2.9815,
            Date = new DateTime(year: 2021, month: 10, day: 1)
        };
        public IEnumerable<ICrimeIncidentModel> CrimeIncidentModels { get; set; }

        public CrimeDataModel(IApiProcessor _apiProcessor) => apiProcessor = _apiProcessor;
        public void OnGet()
        {
        }
        public void OnPostLoadCrimeIncidentModels() => CrimeIncidentModels = apiProcessor.LoadIncidents(QueryModel.Latitude, QueryModel.Longitude, $"{QueryModel.Date.Year}-{QueryModel.Date.Month}").Result;
        public void OnPostLoadSampleCrimeIncidentData()
        {
            CrimeIncidentModels = apiProcessor.LoadIncidents(SampleQueryModel.Latitude, SampleQueryModel.Longitude, $"{SampleQueryModel.Date.Year}-{SampleQueryModel.Date.Month}").Result;
            SetQueryModelWithSampleData();
        }
        // Sets the query model with sample data for form input display.
        private void SetQueryModelWithSampleData()
        {
            QueryModel = new QueryModel
            {
                Latitude = 51.3509,
                Longitude = -2.9815,
                Date = new DateTime(year: 2021, month: 10, day: 1)
            };
        }
    }
}
