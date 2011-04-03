using System;

namespace Tariki.CompanyHouse.Api.Model
{
    public class OfficerSearchItem
    {
        public string Title { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string PostTown { get; set; }
        public string Postcode { get; set; }
        public string CountrOfResidence { get; set; }
        public string PersonID { get; set; }
    }
}