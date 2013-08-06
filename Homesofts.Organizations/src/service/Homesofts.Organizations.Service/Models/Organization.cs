using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homesofts.Organizations.Service.Models
{
    public class Organization
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string BaseCurrency { get; set; }
        public string Language { get; set; }
        public string TimeZoneId { get; set; }
        public string TimeZoneName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
    }
}
