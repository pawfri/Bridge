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
    [DataRow(175.95, 2025, 9, 27)]
    [DataRow(175.95, 2025, 9, 28)]
    [DataRow(175.95, 2025, 10, 4)]
    [DataRow(175.95, 2026, 3, 1)]
    [DataRow(175.95, 2024, 12, 29)]
    [TestMethod()]
    public void WeekendDiscountCarWithBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var car = new Car("AB98123", new DateTime(year, month, day), true);

        // Act
        double actual = StoreBaelt.WeekendDiscount(car);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }
}