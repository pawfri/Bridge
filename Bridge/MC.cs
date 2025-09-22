using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

/// <summary>
/// Class representing a MC (Motorcycle) with a license plate and date
/// </summary>
public class MC : Vehicle
{
    /// <summary>
    /// Initializes a new instance of the MC class with license plate, and date
    /// and inherits from the vehicle base class
    /// </summary>
    /// <param name="licenseplate">A string consisting of numbers and letters</param>
    /// <param name="date">Date associated with the motorcycle</param>
    public MC(string licenseplate, DateTime date)
        : base(licenseplate, date)
    { 
    }

    /// <summary>
    /// Returns fixed price as a double
    /// </summary>
    /// <returns>The price of the vehicle</returns>
    public override double Price()
    {
        return 120.0;
    }

    /// <summary>
    /// Returns vehicle type as a string
    /// </summary>
    /// <returns>The type of vehicle</returns>
    public override string VehicleType()
    {
        return "MC";
    }
}
