using System.Collections.Generic;
using System.Xml.Serialization;
namespace Tariki.CompanyHouse.Api.Model
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
    [XmlRoot("NameSearch", Namespace = "http://xmlgw.companieshouse.gov.uk/v1-0/schema")]
    public class NameSearch
    {
        public NameSearch()
        {
            CoSearchItem = new List<CoSearchCPLXType>();
        }
        public string ContinuationKey { get; set; }
        public string RegressionKey { get; set; }
        public string SearchRows { get; set; }
        public List<CoSearchCPLXType> CoSearchItem { get; set; }
    }
}