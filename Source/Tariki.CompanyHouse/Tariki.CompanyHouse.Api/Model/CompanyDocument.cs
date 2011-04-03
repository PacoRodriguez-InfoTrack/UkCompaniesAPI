using System.Xml.Serialization;
namespace Tariki.CompanyHouse.Api.Model
{
    [XmlRoot(ElementName = "Document", Namespace = "http://xmlgw.companieshouse.gov.uk/v1-0/schema")]
    public class Document
    {
        public string CompanyNumber { get; set; }
        public string FormType { get; set; }
        public int NumPages { get; set; }
    }
}