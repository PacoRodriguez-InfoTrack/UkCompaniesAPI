using System.Collections.Generic;
using Tariki.CompanyHouse.Api.Model;

namespace Tariki.CompanyHouse.Api.Request
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
}