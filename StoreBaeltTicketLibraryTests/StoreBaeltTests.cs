using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using Bridge;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests;

[ExcludeFromCodeCoverage]

[TestClass()]
public class StoreBaeltTests
{
    [DataRow(175.95)]
    [TestMethod()]
    public void WeekendDiscountSaturdayCarWithBrobizzTest(double expected)
    {
        // Arrange
        var car = new Car("AB98123", new DateTime(2025, 9, 27), true);

        // Act
        double actual = StoreBaelt.WeekendDiscount(car);

        // Assert       
        Assert.AreEqual(expected, actual, 0.001);
    }

    [DataRow(175.95)]
    [TestMethod()]
    public void WeekendDiscountSundayCarWithBrobizzTest(double expected)
    {
        // Arrange
        var car = new Car("AB98123", new DateTime(2025, 9, 28), true);

        // Act
        double actual = StoreBaelt.WeekendDiscount(car);

        // Assert       
        Assert.AreEqual(expected, actual, 0.001);
    }
}