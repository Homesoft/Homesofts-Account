using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using System.Globalization;

namespace Homesofts.Organizations.Test.Units
{
    [Subject("Get All Country")]
    public class when_get_all_country
    {
        static List<string> cultures;
        Establish context = () =>
        {
            cultures = new List<string>();
        };

        Because of = () =>
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                cultures.Add(new RegionInfo(ci.LCID).NativeName);
            }
        };

        It should_be_any_country_Indonesia = () =>
        {
            var a = cultures.FirstOrDefault(i => i.Contains("Indonesia"));
            a.ShouldNotBeNull();
        };
    }
}
