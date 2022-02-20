
namespace Web_API_Library.Models
{
    public interface ICrimeIncidentModel
    {
        public string Category { get; set; }
        public string Location_Type { get; set; }
        public Location Location { get; set; }
        public string Month { get; set; }
    }
}
