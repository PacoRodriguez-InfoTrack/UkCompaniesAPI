namespace Tariki.CompanyHouse.Api.Tests.ModelXml
{
    public class TestPayloadXml
    {
        public const string Document =
            @"  <Document xmlns=""http://xmlgw.companieshouse.gov.uk/v1-0/schema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://xmlgw.companieshouse.gov.uk/v1-0/schema http://xmlgw.companieshouse.gov.uk/v1-0/schema/CompanyDocument.xsd""><CompanyNumber>99999999</CompanyNumber>	<NumPages>2</NumPages>	<FormType>288a</FormType> </Document>";

        public const string NumberSearch =
            @"<NumberSearch xmlns=""http://xmlgw.companieshouse.gov.uk/v1-0/schema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://xmlgw.companieshouse.gov.uk/v1-0/schema http://xmlgw.companieshouse.gov.uk/v1-0/schema/NumberSearch.xsd"">
<SearchRows>1</SearchRows>  <CoSearchItem>    <CompanyName>TEST COMPANY LIMITED</CompanyName>    <CompanyNumber>99999999</CompanyNumber>    <DataSet>LIVE</DataSet>    <CompanyIndexStatus>EFFECTIVE</CompanyIndexStatus>    <CompanyDate>2002-09-24+06:00</CompanyDate>  </CoSearchItem></NumberSearch>";

    }
}