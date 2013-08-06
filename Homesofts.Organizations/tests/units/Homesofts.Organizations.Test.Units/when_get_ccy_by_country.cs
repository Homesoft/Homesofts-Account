using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using System.Globalization;

namespace Homesofts.Organizations.Test.Units
{
    [Subject("Get Currency By Country")]
    public class when_get_ccy_by_country
    {
        static string currency;

        Establish context = () =>
        {
        };

        Because of = () =>
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                if (ci.EnglishName.Contains("Australi"))
                {
                    currency = new RegionInfo(ci.LCID).ISOCurrencySymbol;
                }
            }
        };

        It should_be_like_IDR = () =>
        {
            currency.Contains("IDR").ShouldBeTrue();
        };
    }
}
