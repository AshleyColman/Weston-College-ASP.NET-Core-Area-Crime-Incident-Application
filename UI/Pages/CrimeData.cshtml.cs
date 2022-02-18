using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_API_Library.Models;
using Web_API_Library.Services;

namespace UI.Pages
{
    public class CrimeDataModel : PageModel
    {
        private readonly IApiProcessor apiProcessor;

        public CrimeDataModel(IApiProcessor _apiProcessor) => apiProcessor = _apiProcessor;
        public void OnGet() => CrimeIncidentModels = apiProcessor.LoadIncidents(51.3509, -2.9815, "2021-10").Result;
        public IEnumerable<ICrimeIncidentModel> CrimeIncidentModels { get; set; }
    }
}
