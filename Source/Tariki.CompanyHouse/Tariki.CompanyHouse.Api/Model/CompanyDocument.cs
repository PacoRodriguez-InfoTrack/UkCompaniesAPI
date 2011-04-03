
using System;
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
    public class DocumentInfoRequest
    {
        public string CompanyNumber { get; set; }
        public string CompanyName { get; set; }
        public string ImageKey { get; set; }
    }
    public class DocumentInfo
    {
        public string CompanyNumber { get; set; }
        public string FormType { get; set; }
        public string NumPages { get; set; }
        public DateTime? MadeUpDate { get; set; }
        public string DocRequestKey { get; set; }
        public Media Media { get; set; }
    }
    public class DocumentRequest
    {
        public string DocRequestKey { get; set; }
        public string UserReference { get; set; }
    }

}