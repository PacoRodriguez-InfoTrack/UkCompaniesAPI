using System;
using Tariki.CompanyHouse.Api.Model;

namespace Tariki.CompanyHouse.Api.Helpers
{
    public class NullableCompanyIndexStatus : Nullable<CompanyIndexStatus>
    {
        protected override CompanyIndexStatus RenderValue(string valueString)
        {
            return (CompanyIndexStatus)Enum.Parse(typeof(CompanyIndexStatus), valueString);
        }
    }
}