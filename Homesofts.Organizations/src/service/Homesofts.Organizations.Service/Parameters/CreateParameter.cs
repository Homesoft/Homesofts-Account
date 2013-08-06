using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Homesofts.Extension;
using System.Globalization;

namespace Homesofts.Organizations.Service.Parameters
{
    public class CreateParameter
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string CultureId { get; set; }
        public string IpAddress { get; set; }

        public void Validate()
        {
            if (this.Email.IsNullOrWhiteSpace())
                throw new ArgumentNullException("Email harus diisi.");
            if (this.Name.IsNullOrWhiteSpace())
                throw new ArgumentNullException("Nama Perusahaan harus diisi");
            if (this.CultureId.IsNullOrWhiteSpace())
                throw new ArgumentNullException("Negara harus diisi");
        }

        public Models.Organization ParseToOrganization()
        {
            Models.Organization org = new Models.Organization
            {
                Id = Guid.NewGuid().ToString(),
                Name = this.Name,
                Email = this.Email,
                Country = Globalization.Instance.GetCountryByCultureId(this.CultureId),
                BaseCurrency = Globalization.Instance.GetCurrencyByCultureId(this.CultureId),
                Language = Globalization.Instance.GetLanguageByCultureId(this.CultureId),
                TimeZoneId = TimeZoneInfo.Local.Id,
                TimeZoneName = Globalization.Instance.GetTimeZoneById(TimeZoneInfo.Local.Id),
                Address = string.Empty,
                City = string.Empty,
                Phone = string.Empty,
                PostalCode = string.Empty,
                Province = string.Empty,
                Website = string.Empty
            };
            return org;
        }
    }
}
