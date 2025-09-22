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
    public bool Brobizz { get; set; }

    /// <summary>
    /// Initializes a new instance of the Vehicle class with a specified date
    /// </summary>
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    /// <param name="date">Date associated with the vehicle</param> 
    public Vehicle(string licensePlate, DateTime date, bool brobizz)
    {
        LicensePlate = licensePlate;
        Date = date;
        Brobizz = brobizz;

        LicensePlateLengthLimit();
    }

    /// <summary>
    /// Returns fixed price as a double
    /// </summary>
    /// <returns>A double of the vehicle price</returns>
    public abstract double Price();

    /// <summary>
    /// Returns vehicle type as a string
    /// </summary>
    /// <returns>A string of the vehicle type</returns>
    public abstract string VehicleType();

    /// <summary>
    /// Validate if license plate is longer than maximum 7 characters
    /// </summary>
    /// <exception cref="Exception">Throws an excepsion if license plate is too long</exception>
    public void LicensePlateLengthLimit()
    {
        if (LicensePlate.Length > 7)
        {
            throw new Exception("License plate may not be longer than 7 characters");
        }
    }

}
