using System;

namespace Tariki.CompanyHouse.Api.Helpers
{
    public static class EnumHelper
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

    }
}