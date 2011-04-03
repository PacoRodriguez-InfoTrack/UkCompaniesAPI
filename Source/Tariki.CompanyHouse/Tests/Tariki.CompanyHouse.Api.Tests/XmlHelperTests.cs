using System;
using System.Collections.Generic;
using NUnit.Framework;
using Tariki.CompanyHouse.Api.Model;
using System.Linq;

namespace Tariki.CompanyHouse.Api.Tests
{
    [TestFixture]
    public class XmlHelperTests
    {
        [Test]
        public void Deseralise_LoadCompanyDocumentFromXml()
        {
            Document document = XmlHelper<Document>.Deserialize(ModelXml.TestPayloadXml.Document);
            Assert.AreEqual("99999999", document.CompanyNumber);
            Assert.AreEqual("288a", document.FormType);
            Assert.AreEqual(2, document.NumPages);
        }

        [Test]
        public void Seralise_LoadCompanyDocumentFromXml()
        {
            string expected = "<?xml version=\"1.0\"?>\r\n<Document xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns=\"http://xmlgw.companieshouse.gov.uk/v1-0/schema\">\r\n  <CompanyNumber>CAD432</CompanyNumber>\r\n  <FormType>form_0</FormType>\r\n  <NumPages>6</NumPages>\r\n</Document>";
            Document document = new Document { CompanyNumber = "CAD432", FormType = "form_0", NumPages = 6 };
            string xml = XmlHelper<Document>.Serialize(document);
            Assert.AreEqual(expected, xml);
        }
        [Test]
        public void Deseralise_NumberSearch()
        {
            NumberSearch numberSearch = XmlHelper<NumberSearch>.Deserialize(ModelXml.TestPayloadXml.NumberSearch);
            Assert.AreEqual(1, numberSearch.SearchRows);
            Assert.AreEqual(1, numberSearch.SearchItems.Count);
            var item = numberSearch.SearchItems.First();
            Assert.AreEqual(item.CompanyIndexStatus, CompanyIndexStatus.EFFECTIVE);
        }


        [Test]
        public void Seralise_NumberSearch()
        {
            var expected =
                "<?xml version=\"1.0\"?>\r\n<NumberSearch xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns=\"http://xmlgw.companieshouse.gov.uk/v1-0/schema\">\r\n  <SearchRows>0</SearchRows>\r\n  <CoSearchItem>\r\n    <CompanyName>Tree Huggers Ltd</CompanyName>\r\n    <DataSet>LIVE</DataSet>\r\n    <CompanyDate>2009-11-01T00:00:00</CompanyDate>\r\n    <CompanyIndexStatus xsi:nil=\"true\" />\r\n    <SearchMatch xsi:nil=\"true\" />\r\n  </CoSearchItem>\r\n</NumberSearch>";

            NumberSearch numberSearch = new NumberSearch()
                                        {
                                            SearchItems = new List<CoSearchCPLXType>
                                                               {
                                                                   new CoSearchCPLXType()
                                                                       {CompanyDate = new DateTime(2009, 11, 01),CompanyName = "Tree Huggers Ltd"}}
                                        };
            string xml = XmlHelper<NumberSearch>.Serialize(numberSearch);
            Assert.AreEqual(expected, xml);

        }


    }
}