using System.Collections.Generic;
using System.Xml.Serialization;
namespace Tariki.CompanyHouse.Api.Model
{
    [XmlRoot("NameSearch", Namespace = "http://xmlgw.companieshouse.gov.uk/v1-0/schema")]
    public class NameSearch
    {
        public NameSearch()
        {
            Results = new List<SearchResult>();
        }
        public string ContinuationKey { get; set; }
        public string RegressionKey { get; set; }
        public int SearchRows { get; set; }
        [XmlElement("CoSearchItem")]
        public List<SearchResult> Results { get; set; }
    }
}