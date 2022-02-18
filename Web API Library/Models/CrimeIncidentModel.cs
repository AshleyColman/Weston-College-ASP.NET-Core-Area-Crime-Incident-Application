﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Web_API_Library.Models
{
    public class CrimeIncidentModel : ICrimeIncidentModel
    {
        [JsonPropertyName("category")] public string Category { get; set; }
        [JsonPropertyName("location_type")] public string Location_Type { get; set; }
        [JsonPropertyName("location")] public Location Location { get; set; }
        [JsonPropertyName("month")] public string Month { get; set; }
    }
}
