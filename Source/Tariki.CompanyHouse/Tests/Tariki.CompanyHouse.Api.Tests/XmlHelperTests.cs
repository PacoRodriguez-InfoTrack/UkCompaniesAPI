using System;
using System.Collections.Generic;
using NUnit.Framework;
using Tariki.CompanyHouse.Api.Helpers;
using Tariki.CompanyHouse.Api.Model;
using System.Linq;
using Tariki.CompanyHouse.Api.Response;

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
        public void Deseralise_NumberSearch()
        {
            NumberSearch numberSearch = XmlHelper<NumberSearch>.Deserialize(ModelXml.TestPayloadXml.NumberSearch);
            Assert.AreEqual(1, numberSearch.SearchRows);
            Assert.AreEqual(1, numberSearch.SearchItems.Count);
            var item = numberSearch.SearchItems.First();
            Assert.AreEqual(item.CompanyIndexStatus.Value, CompanyIndexStatus.EFFECTIVE);
        }


        [Test]
        public void Deseralise_NameSearch()
        {
            NameSearch numberSearch = XmlHelper<NameSearch>.Deserialize(ModelXml.TestPayloadXml.NameSearch);
            Assert.AreEqual(100, numberSearch.SearchRows);
            Assert.AreEqual(100, numberSearch.Results.Count);
        }

        [Test]
        public void Deseralise_NameSearch_100ResultsReturned()
        {
            var results = XmlHelper<NameSearch>.Deserialize(ModelXml.TestPayloadXml.NameSearch).Results;
            Assert.AreEqual(100, results.Count);
        }

        [Test]
        public void Deseralise_NameSearch_FirstResultComplete()
        {
            DateTime dateTime = new DateTime(2009,11,01);
            const string name = "TESQUIRE LIMITED";
            const string number = "06114228";
            
            SearchResult result = XmlHelper<NameSearch>.Deserialize(ModelXml.TestPayloadXml.NameSearch).Results.First();

            Assert.AreEqual(dateTime,result.CompanyDate.Value);
            Assert.AreEqual(name,result.CompanyName);
            Assert.AreEqual(number,result.CompanyNumber);
            Assert.AreEqual(CompanyIndexStatus.DISSOLVED,result.CompanyIndexStatus.Value);
            Assert.AreEqual(DataSet.LIVE,result.DataSet);
            Assert.AreEqual(SearchMatch.NEAR,result.SearchMatch.Value);
        }



    }
}