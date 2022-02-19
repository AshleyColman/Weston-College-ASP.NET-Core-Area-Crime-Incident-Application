using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API_Library.Models;

namespace Web_API_Library.Services
{
    public interface IApiProcessor
    {
        public Task<IEnumerable<CrimeIncidentModel>> LoadIncidents(double _latitude, double _longitude, string _date);
    }
}
