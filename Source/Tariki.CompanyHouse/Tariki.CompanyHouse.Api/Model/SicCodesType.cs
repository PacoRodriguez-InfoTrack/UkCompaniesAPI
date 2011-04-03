using System.Collections.Generic;

namespace Tariki.CompanyHouse.Api.Model
{
    public class SicCodesType
    {
        public SicCodesType()
        {
            SicText = new List<string>();
        }
        public List<string> SicText { get; set; }
    }
}