using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using UI.Pages;
using Web_API_Library.Models;
using Web_API_Library.Services;
using Web_API_Library.Validation;

namespace Tests.Web_API
{
    [TestClass]
    public sealed class WebApiLibraryTests
    {
        [TestMethod]
        [DataRow(51.3509, -2.9815, 2021, 10)]
        [DataRow(53, 0, 2019, 5)]
        [DataRow(52, 0, 2019, 1)]
        public void LoadIncidents_ReturnsResults_True(double _latitude, double _longitude, int _year, int _month)
        {
            ApiProcessor processor = new();

            IEnumerable<ICrimeIncidentModel> crimeIncidentModels = processor.LoadIncidents(_latitude, _longitude, $"{_year}-{_month}").Result;

            Assert.IsTrue(crimeIncidentModels.Any());
        }

        [TestMethod]
        [DataRow(0, 0, 2021, 1)]
        [DataRow(10, -10, 2020, 10)]
        [DataRow(5, -5, 2019, 5)]
        public void LoadIncidents_ReturnsResults_False(double _latitude, double _longitude, int _year, int _month)
        {
            ApiProcessor processor = new();

            IEnumerable<ICrimeIncidentModel> crimeIncidentModels = processor.LoadIncidents(_latitude, _longitude, $"{_year}-{_month}").Result;

            Assert.IsFalse(crimeIncidentModels.Any());
        }

        [TestMethod]
        public void CrimeDataModel_SampleQueryModelDataIsSet_True()
        {
            ApiProcessor processor = new ApiProcessor();

            CrimeDataModel crimeDataModel = new (processor);
  
            IQueryModel queryModel = crimeDataModel.SampleQueryModel;

            Assert.AreEqual(queryModel.Latitude, 51.3509);
            Assert.AreEqual(queryModel.Longitude, -2.9815);
            Assert.AreEqual(queryModel.Date, new DateTime(year: 2021, month: 10, day: 1));
        }

        [TestMethod]
        public void CrimeDataModel_SampleQueryModelDataIsSet_False()
        {
            ApiProcessor processor = new ApiProcessor();

            CrimeDataModel crimeDataModel = new(processor);

            IQueryModel queryModel = crimeDataModel.SampleQueryModel;

            Assert.AreNotEqual(queryModel.Latitude, 0);
            Assert.AreNotEqual(queryModel.Longitude, 0);
            Assert.AreNotEqual(queryModel.Date, new DateTime(year: 2019, month: 5, day: 5));
        }

        [TestMethod]
        [DataRow(2015, 5, 1)]
        [DataRow(2016, 6, 1)]
        [DataRow(2017, 7, 1)]
        public void ValidationAttribute_ValidDate_True(int _year, int _month, int _day)
        {
            ValidDate dateAttribute = new();

            DateTime date = new(_year, _month, _day);

            Assert.IsTrue(dateAttribute.IsValid(date));
        }

        [TestMethod]
        [DataRow(2030, 1, 1)]
        [DataRow(2050, 5, 5)]
        [DataRow(3000, 10, 10)]
        public void ValidationAttribute_ValidDate_False(int _year, int _month, int _day)
        {
            ValidDate dateAttribute = new();

            DateTime date = new(_year, _month, _day);

            Assert.IsFalse(dateAttribute.IsValid(date));
        }
    }
}