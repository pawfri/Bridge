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
    // Tests relevant for Cars

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

    [DataRow(195.5, 2025, 9, 27)]
    [DataRow(195.5, 2025, 9, 28)]
    [DataRow(195.5, 2025, 10, 4)]
    [DataRow(195.5, 2026, 3, 1)]
    [DataRow(195.5, 2024, 12, 29)]
    [TestMethod()]
    public void WeekendDiscountCarWithoutBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var car = new Car("AB98123", new DateTime(year, month, day), false);

        // Act
        double actual = StoreBaelt.WeekendDiscount(car);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }

    [DataRow(207.0, 2025, 9, 22)]
    [DataRow(207.0, 2025, 9, 26)]
    [DataRow(207.0, 2025, 10, 1)]
    [DataRow(207.0, 2026, 3, 3)]
    [DataRow(207.0, 2024, 12, 31)]
    [TestMethod()]
    public void NormalWeekDayCarWithBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var car = new Car("AB98123", new DateTime(year, month, day), true);

        // Act
        double actual = StoreBaelt.WeekendDiscount(car);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }

    [DataRow(230.0, 2025, 9, 22)]
    [DataRow(230.0, 2025, 9, 26)]
    [DataRow(230.0, 2025, 10, 1)]
    [DataRow(230.0, 2026, 3, 3)]
    [DataRow(230.0, 2024, 12, 31)]
    [TestMethod()]
    public void NormalWeekDayCarWithoutBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var car = new Car("AB98123", new DateTime(year, month, day), false);

        // Act
        double actual = StoreBaelt.WeekendDiscount(car);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }

    // Tests relevant to Motorcycles

    [DataRow(108.0, 2025, 9, 27)]
    [DataRow(108.0, 2025, 9, 28)]
    [DataRow(108.0, 2025, 10, 4)]
    [DataRow(108.0, 2026, 3, 1)]
    [DataRow(108.0, 2024, 12, 29)]
    [TestMethod()]
    public void WeekendDiscountMCWithBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var mc = new MC("AB98123", new DateTime(year, month, day), true);

        // Act
        double actual = StoreBaelt.WeekendDiscount(mc);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }

    [DataRow(120.0, 2025, 9, 27)]
    [DataRow(120.0, 2025, 9, 28)]
    [DataRow(120.0, 2025, 10, 4)]
    [DataRow(120.0, 2026, 3, 1)]
    [DataRow(120.0, 2024, 12, 29)]
    [TestMethod()]
    public void WeekendDiscountMCWithoutBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var mc = new MC("AB98123", new DateTime(year, month, day), false);

        // Act
        double actual = StoreBaelt.WeekendDiscount(mc);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }

    [DataRow(108.0, 2025, 9, 22)]
    [DataRow(108.0, 2025, 9, 26)]
    [DataRow(108.0, 2025, 10, 1)]
    [DataRow(108.0, 2026, 3, 3)]
    [DataRow(108.0, 2024, 12, 31)]
    [TestMethod()]
    public void NormalWeekDayMCWithBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var mc = new MC("AB98123", new DateTime(year, month, day), true);

        // Act
        double actual = StoreBaelt.WeekendDiscount(mc);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }

    [DataRow(120.0, 2025, 9, 22)]
    [DataRow(120.0, 2025, 9, 26)]
    [DataRow(120.0, 2025, 10, 1)]
    [DataRow(120.0, 2026, 3, 3)]
    [DataRow(120.0, 2024, 12, 31)]
    [TestMethod()]
    public void NormalWeekDayMCWithoutBrobizzTest(double expectedPrice, int year, int month, int day)
    {
        // Arrange
        var mc = new MC("AB98123", new DateTime(year, month, day), false);

        // Act
        double actual = StoreBaelt.WeekendDiscount(mc);

        // Assert       
        Assert.AreEqual(expectedPrice, actual, 0.001);
    }
}