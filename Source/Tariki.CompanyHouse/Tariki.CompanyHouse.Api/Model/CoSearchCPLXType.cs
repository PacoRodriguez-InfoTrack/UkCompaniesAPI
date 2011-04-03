using System;

namespace Tariki.CompanyHouse.Api.Model
{
    public class CoSearchCPLXType
    {
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public DataSet DataSet { get; set; }
        public DateTime? CompanyDate { get; set; }
        public CompanyIndexStatus? CompanyIndexStatus { get; set; }
        public SearchMatch? SearchMatch { get; set; }
    }
}