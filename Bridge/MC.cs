using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

/// <summary>
/// Class representing a MC (Motorcycle) with a license plate and date
/// </summary>
public class MC
{
    public string Licenseplate { get; set; }
    public DateTime Date { get; set; }


    /// <summary>
    /// Initializes a new instace of the MC class with license plate and date
    /// </summary>
    /// <param name="licenseplate">A string consisting of numbers and letters</param>
    /// <param name="date">Date associated with the car</param>
    public MC(string licenseplate, DateTime date)
    { 
        Licenseplate = licenseplate; 
        Date = date; 
    }

    /// <summary>
    /// Returns fixed price as a double
    /// </summary>
    /// <returns>The price of the vehicle</returns>
    public double Price()
    {
        return 120.0;
    }

    /// <summary>
    /// Returns vehicle type as a string
    /// </summary>
    /// <returns>The type of vehicle</returns>
    public string VehicleType()
    {
        return "MC";
    }
}
