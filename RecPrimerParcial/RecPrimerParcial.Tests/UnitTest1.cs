using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecPrimerParcial.Controllers;

namespace RecPrimerParcial.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCountry()
        {
            //Arrange
            CountriesController countries = new CountriesController();

            //Act
            var ListCountry = countries.GetCountries();

            //Assert
            Assert.IsNotNull(ListCountry);
        }
    }
}
