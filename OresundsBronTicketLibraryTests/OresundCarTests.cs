using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundsBronTicketLibrary;
using Bridge;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundsBronTicketLibrary.Tests;

[ExcludeFromCodeCoverage]

[TestClass()]
public class OresundCarTests
{
    [DataRow(460.0)]
    [DataRow(460)]
    [TestMethod()]
    public void OresundCarPriceWithoutBrobizzTest(double expected)
    {
        // Arrange
        var car = new OresundCar("XY12456", false);
        
        // Act
        double result = car.Price();

        // Assert
        Assert.AreEqual(expected, result, 0.001);
    }

    [DataRow(178.0)]
    [DataRow(178)]
    [TestMethod()]
    public void OresundCarPriceWithBrobizzTest(double expected)
    {
        // Arrange
        var car = new OresundCar("XY12456", new DateTime(2025,9,25), true);

        // Act
        double result = car.Price();

        // Assert
        Assert.AreEqual(expected, result, 0.001);
    }

    [DataRow("Oresund Car")]
    [TestMethod()]
    public void OresundCarVehicleTypeTest(string expected)
    {
        // Arrange
        var car = new OresundCar("XY12456", true);

        // Act
        string result = car.VehicleType();

        // Assert
        Assert.AreEqual(expected, result);
    }

}