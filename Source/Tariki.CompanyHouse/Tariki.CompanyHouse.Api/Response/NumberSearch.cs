using System.Collections.Generic;
using System.Xml.Serialization;
namespace Tariki.CompanyHouse.Api.Model
{
    [XmlRoot("NumberSearch", Namespace = "http://xmlgw.companieshouse.gov.uk/v1-0/schema")]
    public class NumberSearch
    {
        public NumberSearch()
        {
            SearchItems = new List<SearchResult>();
        }
        public int SearchRows { get; set; }

        [XmlElement("CoSearchItem")]
        public List<SearchResult> SearchItems { get; set; }
    }
}