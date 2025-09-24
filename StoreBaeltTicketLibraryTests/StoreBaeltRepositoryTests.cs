using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests;

[TestClass()]
public class StoreBaeltRepositoryTests
{
    [TestInitialize]
    public void ClearStaticList()
    {
        StoreBaeltRepository.GetAll().Clear();
    }

    [DataRow("YX56123", true)]
    [DataRow("BA98123", false)]
    [DataRow("CF54524", false)]
    [TestMethod]
    public void AddTicketTest(string licensePlate, bool broBizz)
    {
        // Arrange
        var car = new Car(licensePlate, broBizz);

        // Act
        StoreBaeltRepository.AddTicket(car);

        // Assert
        Assert.AreEqual(licensePlate, StoreBaeltRepository.GetAll()[0].LicensePlate);
    }
}