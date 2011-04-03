using Tariki.CompanyHouse.Api.Helpers;

namespace Tariki.CompanyHouse.Api.Model
{
    public class SearchResult
    {
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public DataSet DataSet { get; set; }
        public NullableDateTime CompanyDate { get; set; }
        public NullableCompanyIndexStatus CompanyIndexStatus { get; set; }
        public NullableSearchMatch SearchMatch { get; set; }
    }
}

