using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Homesofts.Organizations.Test.Units
{
    public class when_get_all_timezone
    {
        static IList<string> timezone;

        Establish context = () =>
        {
            timezone = new List<string>();
        };

        Because of = () =>
        {
            foreach (TimeZoneInfo tz in TimeZoneInfo.GetSystemTimeZones())
            {
                timezone.Add(tz.DisplayName);
            }
        };

        It should_be_any_Jakarta = () =>
        {
            timezone.FirstOrDefault(i => i.Contains("Jakarta")).ShouldNotBeNull();
        };
    }
}
