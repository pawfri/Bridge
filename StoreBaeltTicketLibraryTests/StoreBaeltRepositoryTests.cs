using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Testing.Platform.MSBuild;

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

    [TestMethod]
    public void GetAllTicketsTest()
    {
        // Arrange
        var car = new Car("YX12389", false);
        var car2 = new MC("BX87456", true);

        // Act
        StoreBaeltRepository.AddTicket(car);
        StoreBaeltRepository.AddTicket(car2);

        // Assert
        Assert.AreEqual(2, StoreBaeltRepository.GetAll().Count);
    }

    [DataRow("YX12389", 2)]
    [DataRow("BX87456", 1)]
    [DataRow("CE87953", 1)]
    [DataRow("ZE56218", 0)]
    [TestMethod]
    public void GetTicketsLicensePlateTest(string licensePlate, int expectedCount)
    {
        // Arrange
        var ticket = new Car("YX12389", false);
        var ticket2 = new Car("YX12389", false);
        var ticket3 = new Car("BX87456", true);
        var ticket4 = new MC("CE87953", true);

        // Act
        StoreBaeltRepository.AddTicket(ticket);
        StoreBaeltRepository.AddTicket(ticket2);
        StoreBaeltRepository.AddTicket(ticket3);
        StoreBaeltRepository.AddTicket(ticket4);

        // Assert
        Assert.AreEqual(expectedCount, StoreBaeltRepository.GetTicketsLicensePlate(licensePlate).Count);
    }
}