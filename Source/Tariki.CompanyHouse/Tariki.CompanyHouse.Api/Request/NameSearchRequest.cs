using Tariki.CompanyHouse.Api.Model;

namespace Tariki.CompanyHouse.Api.Request
{
    public class NameSearchRequest
    {
        public string CompanyName { get; set; }
        public bool? SameAs { get; set; }
        public string SearchRows { get; set; }
        public string ContinuationKey { get; set; }
        public string RegressionKey { get; set; }
        public DataSet DataSet { get; set; }
    }
}