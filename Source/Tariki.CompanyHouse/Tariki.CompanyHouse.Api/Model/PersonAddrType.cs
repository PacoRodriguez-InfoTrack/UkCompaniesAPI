using System.Collections.Generic;

namespace Tariki.CompanyHouse.Api.Model
{
    public class PersonAddrType
    {
        public PersonAddrType()
        {
            AddressLine = new List<string>();
        }
        public string PostTown { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public bool? ServiceAddressInd { get; set; }
        public List<string> AddressLine { get; set; }
    }
}