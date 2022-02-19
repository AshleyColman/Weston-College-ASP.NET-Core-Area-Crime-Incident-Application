namespace Web_API_Library.Models
{
    public interface ILocation
    {
        public string Latitude { get; set; }
        public Street Street { get; set; }
        public string Longitude { get; set; }
    }
}
