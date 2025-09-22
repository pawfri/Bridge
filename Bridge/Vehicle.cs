using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

/// <summary>
/// Base abstract class for all vehicles
/// </summary>
public abstract class Vehicle
{
    public string LicensePlate { get; }
    public DateTime Date { get; }

    /// <summary>
    /// Initializes a new instance of the Vehicle class with a specified date
    /// </summary>
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    /// <param name="date">Date associated with the vehicle</param> 
    public Vehicle(string licensePlate, DateTime date)
    {
        LicensePlate = licensePlate;
        Date = date;
    }

    /// <summary>
    /// Returns fixed price as a double
    /// </summary>
    /// <returns>A double of the vehicle price</returns>
    public abstract double Price();

    /// <summary>
    /// Abstract method
    /// </summary>
    /// <returns>A string of the vehicle type</returns>
    public abstract string VehicleType();

}
