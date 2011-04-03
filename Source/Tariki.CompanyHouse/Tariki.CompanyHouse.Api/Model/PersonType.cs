using System;
using System.Collections.Generic;

namespace Tariki.CompanyHouse.Api.Model
{
    public class PersonType
    {
        public PersonType()
        {
            PersonAddress = new PersonAddrType();
            Forename = new List<string>();
        }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Honours { get; set; }
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        public string PersonID { get; set; }
        public List<string> Forename { get; set; }
        public PersonAddrType PersonAddress { get; set; }
    }
}