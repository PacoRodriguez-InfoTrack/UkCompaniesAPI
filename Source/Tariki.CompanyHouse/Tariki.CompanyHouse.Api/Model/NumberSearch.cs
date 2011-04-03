using System.Collections.Generic;
using System.Xml.Serialization;
namespace Tariki.CompanyHouse.Api.Model
{
    public class NumberSearchRequest
    {
        public NumberSearchRequest()
        {
            DataSet = new List<DataSet>();
        }
        public string PartialCompanyNumber { get; set; }
        public string SearchRows { get; set; }
        public List<DataSet> DataSet { get; set; }
    }

    [XmlRoot("NumberSearch", Namespace = "http://xmlgw.companieshouse.gov.uk/v1-0/schema")]
    public class NumberSearch
    {
        public NumberSearch()
        {
            SearchItems = new List<CoSearchCPLXType>();
        }
        public int SearchRows { get; set; }

        [XmlElement("CoSearchItem")]
        public List<CoSearchCPLXType> SearchItems { get; set; }
    }
}