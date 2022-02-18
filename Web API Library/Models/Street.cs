using System.Text.Json.Serialization;

namespace Web_API_Library.Models
{
    public sealed class Street : IStreet
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
    }
}
