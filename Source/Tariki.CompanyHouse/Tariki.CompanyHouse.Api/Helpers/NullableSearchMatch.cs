using Tariki.CompanyHouse.Api.Model;

namespace Tariki.CompanyHouse.Api.Helpers
{
    public class NullableSearchMatch : Nullable<SearchMatch>
    {
        protected override SearchMatch RenderValue(string valueString)
        {
            return EnumHelper.ParseEnum<SearchMatch>(valueString);
        }
    }
}