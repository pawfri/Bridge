using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTests;

[TestClass()]
public class CarTests
{

    [DataRow(230.0)]
    [DataRow(230)]
    [TestMethod()]
    public void PriceEqualTest(double expected)
    {
        // Arrange
        var car = new Car("AB35987", DateTime.Today);

        // Act
        double actual = car.Price();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [DataRow(229.0)]
    [DataRow(229.9)]
    [DataRow(230.1)]
    [DataRow(231.0)]
    [DataRow(231)]
    [TestMethod()]
    public void PriceNotEqualTest(double notExpected)
    {
        // Arrange
        var car = new Car("AB35987", DateTime.Today);

        // Act
        double actual = car.Price();

        // Assert
        Assert.AreNotEqual(notExpected, actual);
    }

    [DataRow("Car")]
    [TestMethod()]
    public void VehicleTypeEqualTest(string expected)
    {
        // Arrange
        var car = new Car("AB35987", DateTime.Today);

        // Act
        string actual = car.VehicleType();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [DataRow("bus")]
    [DataRow("car")]
    [DataRow("Cars")]
    [DataRow("train")]
    [DataRow("mc")]
    [TestMethod()]
    public void VehicleTypeNotEqualTest(string notExpected)
    {
        // Arrange
        var car = new Car("AB35987", DateTime.Today);

        // Act
        string actual = car.VehicleType();

        // Assert
        Assert.AreNotEqual(notExpected, actual);
    }

    [DataRow("AB35987")]
    [DataRow("1337")]
    [DataRow("AB4008")]
    [TestMethod()]
    public void LicensePlateLengthLimitCreateSuccessfullyTest(string licensePlate)
    {
        // Act
        var car = new Car(licensePlate, DateTime.Today);

        // Assert
        Assert.IsNotNull(car);
    }

    [DataRow("AB35987Y")]
    [DataRow("AB35987Y1")]
    [DataRow("AB35987Y12")]
    [TestMethod()]
    public void LicensePlateLengthLimitThrowExceptionTest(string licensePlate)
    {
        //Arrange
        Exception exception = null;

        // Act
        try
        {
            var car = new Car(licensePlate, DateTime.Today);
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        // Assert
        Assert.IsNotNull(exception);
    }

}