using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundsBronTicketLibrary;
using System;
using Bridge;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundsBronTicketLibrary.Tests;

[ExcludeFromCodeCoverage]

[TestClass()]
public class OresundMCTests
{
    [DataRow(235.0)]
    [DataRow(235)]
    [TestMethod()]
    public void OresundMCPriceWithoutBrobizzTest(double expected)
    {
        // Arrange
        var car = new OresundMC("XY12456", false);

        // Act
        double result = car.Price();

        // Assert
        Assert.AreEqual(expected, result, 0.001);
    }

    [DataRow(92.0)]
    [DataRow(92)]
    [TestMethod()]
    public void OresundMCPriceWithBrobizzTest(double expected)
    {
        // Arrange
        var car = new OresundMC("XY12456", new DateTime(2025, 9, 25), true);

        // Act
        double result = car.Price();

        // Assert
        Assert.AreEqual(expected, result, 0.001);
    }

    [DataRow("Oresund MC")]
    [TestMethod()]
    public void OresundMCVehicleTypeTest(string expected)
    {
        // Arrange
        var car = new OresundMC("XY12456", true);

        // Act
        string result = car.VehicleType();

        // Assert
        Assert.AreEqual(expected, result);
    }
}