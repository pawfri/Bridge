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
    public DateTime Date { get; set; }

    /// <summary>
    /// Initializes a new instace of the Vehicle class with a specified date
    /// </summary>
    /// <param name="date">Date associated with the vehicle</param>
    public Vehicle(DateTime date)
    {
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
