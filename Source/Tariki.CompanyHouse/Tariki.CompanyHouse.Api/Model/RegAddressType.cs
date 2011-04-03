using System.Collections.Generic;

namespace Tariki.CompanyHouse.Api.Model
{
    public class RegAddressType
    {
        public RegAddressType()
        {
            AddressLine = new List<string>();
        }
        public List<string> AddressLine { get; set; }
    }
}