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

    [TestMethod]
    public void GetTicketsLicensePlateTest()
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
        Assert.AreEqual(2, StoreBaeltRepository.GetTicketsLicensePlate("YX12389").Count);
    }
}