
namespace Web_API_Library.Models
{
    public interface IQueryModel
    {
        DateTime Date { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}