using System;

namespace Tariki.CompanyHouse.Api.Model
{
    public class DocumentInfo
    {
        public string CompanyNumber { get; set; }
        public string FormType { get; set; }
        public string NumPages { get; set; }
        public DateTime? MadeUpDate { get; set; }
        public string DocRequestKey { get; set; }
        public Media Media { get; set; }
    }
}