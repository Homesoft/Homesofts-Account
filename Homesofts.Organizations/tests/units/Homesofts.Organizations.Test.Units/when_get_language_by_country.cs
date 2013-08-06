using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using System.Globalization;

namespace Homesofts.Organizations.Test.Units
{
    [Subject("Get Language By Country")]
    public class when_get_language_by_country
    {
        static string language;

        Because of = () =>
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                if (ci.EnglishName.Contains("Indonesia"))
                {
                    language = ci.EnglishName;
                }
            } 
        };

        It should_be_Indonesian = () =>
        {
            language.Contains("Indonesian").ShouldBeTrue();
        };
    }
}
