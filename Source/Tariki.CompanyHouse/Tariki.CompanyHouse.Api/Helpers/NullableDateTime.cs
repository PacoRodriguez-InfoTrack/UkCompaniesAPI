using System;

namespace Tariki.CompanyHouse.Api.Helpers
{
    public class NullableDateTime: Nullable<DateTime>
    {
        protected override DateTime RenderValue(string valueString)
        {
            return DateTime.Parse(valueString);
        }
    }
}