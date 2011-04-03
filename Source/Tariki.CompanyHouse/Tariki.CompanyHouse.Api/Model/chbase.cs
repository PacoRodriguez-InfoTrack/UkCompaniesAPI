using System;
using System.Collections.Generic;

namespace Tariki.CompanyHouse.Api.Model
{
    public enum MortgageInd
    {
        NO,
        LT300,
        GE300,
    }
    public class RegAddressType
    {
        public RegAddressType()
        {
            AddressLine = new List<string>();
        }
        public List<string> AddressLine { get; set; }
    }
    public class SicCodesType
    {
        public SicCodesType()
        {
            SicText = new List<string>();
        }
        public List<string> SicText { get; set; }
    }
    public class PreviousNamesType
    {
        public DateTime CONDate { get; set; }
        public string CompanyName { get; set; }
    }
    public enum Overdue
    {
        NO,
        OVERDUE,
        PENDING,
    }
    public enum DataSet
    {
        LIVE,
        DISSOLVED,
        FORMER,
        PROPOSED,
        SAMEAS,
    }
    public enum CompanyIndexStatus
    {
        EFFECTIVE,
        REJECTED,
        DISSOLVED,
        CNGOFNAME,
        INLIQ,
        REMOVED,
        STATUSR,
    }
    public enum SearchMatch
    {
        NEAR,
        EXACT,
    }
    public enum AppointmentStatus
    {
        CURRENT,
        RESIGNED,
    }
    public enum AppointmentType
    {
        DIR,
        SEC,
        NOMDIR,
        NOMSEC,
        DIRSEC,
        DESMEM,
        MEMBER,
    }
    public enum ApptDatePrefix
    {
        PRE,
    }
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
    public class PersonAddrType
    {
        public PersonAddrType()
        {
            AddressLine = new List<string>();
        }
        public string PostTown { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public bool? ServiceAddressInd { get; set; }
        public List<string> AddressLine { get; set; }
    }
    public class CoSearchCPLXType
    {
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
        public DataSet DataSet { get; set; }
        public DateTime? CompanyDate { get; set; }
        public CompanyIndexStatus? CompanyIndexStatus { get; set; }
        public SearchMatch? SearchMatch { get; set; }
    }
    public enum ChargeSatisfied
    {
        OUTSTANDING,
        SATISFIED,
        PARTSATISFIED,
    }
    public enum Media
    {
        ARCHIVE,
        JUKEBOX,
        CACHE,
        UNAVAILABLE,
    }
    public enum OfficerType
    {
        CUR,
        LLP,
        DIS,
        EUR,
    }
    public enum NumAppInd
    {
        GE1000,
    }
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