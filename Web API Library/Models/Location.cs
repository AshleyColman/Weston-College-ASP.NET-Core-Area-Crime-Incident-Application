using System.Text.Json.Serialization;

namespace Web_API_Library.Models
{
    public sealed class Location : ILocation
    {
        [JsonPropertyName("latitude")] public string Latitude { get; set; }
        [JsonPropertyName("street")] public Street Street { get; set; }
        [JsonPropertyName("longitude")] public string Longitute { get; set; }
    }
}
