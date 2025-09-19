using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Tests;

[TestClass()]
public class MCTests
{

    [DataRow(120.0)]
    [DataRow(120)]
    [TestMethod()]
    public void PriceEqualTest(double expected)
    {
        // Arrange
        var mc = new MC("AB35987", DateTime.Today);

        // Act
        double actual = mc.Price();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [DataRow(121.0)]
    [DataRow(119.9)]
    [DataRow(120.1)]
    [DataRow(222.0)]
    [DataRow(221)]
    [TestMethod()]
    public void PriceNotEqualTest(double notExpected)
    {
        // Arrange
        var mc = new MC("AB35987", DateTime.Today);

        // Act
        double actual = mc.Price();

        // Assert
        Assert.AreNotEqual(notExpected, actual);
    }

    [DataRow("MC")]
    [TestMethod()]
    public void VehicleTypeEqualTest(string exepected)
    {
        // Arrange
        var mc = new MC("AB35987", DateTime.Today);

        // Act
        string actual = mc.VehicleType();

        // Assert
        Assert.AreEqual(exepected, actual);
    }

    [DataRow("bus")]
    [DataRow("car")]
    [DataRow("train")]
    [DataRow("motorcycle")]
    [DataRow("mc")]
    [DataRow("mC")]
    [TestMethod()]
    public void VehicleTypeNotEqualTest(string notExepcted)
    {
        // Arrange
        var mc = new MC("AB35987", DateTime.Today);

        // Act
        string actual = mc.VehicleType();

        // Assert
        Assert.AreNotEqual(notExepcted, actual);
    }
}