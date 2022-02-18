using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
