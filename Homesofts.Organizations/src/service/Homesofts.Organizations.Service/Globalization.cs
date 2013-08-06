using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Homesofts.Organizations.Service
{
    public class Globalization
    {
        public static Globalization Instance = new Globalization();

        public string GetCurrencyByCultureId(string id)
        {
            return new RegionInfo(id).ISOCurrencySymbol;
        }

        public string GetCountryByCultureId(string id)
        {
            return new RegionInfo(id).NativeName;
        }

        public string GetTimeZoneById(string id)
        {
            return TimeZoneInfo.FindSystemTimeZoneById(id).DisplayName;
        }

        public string GetLanguageByCultureId(string id)
        {
            CultureInfo ci = CultureInfo.GetCultureInfo(id);
            return ci.NativeName;
        }
    }
}
