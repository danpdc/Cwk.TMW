using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Models
{
    public record ProfileLocation
    {
        public ProfileLocation(string country, string region, string city)
        {
            Country = country;
            Region = region;
            City = city;
        }

        private ProfileLocation() { }

        public int Id { get; set; }
        string Country { get; init; }
        string Region { get; init; }
        string City { get; init; }
    }
}
