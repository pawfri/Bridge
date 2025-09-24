using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundsBronTicketLibrary;

/// <summary>
/// Class representing a OresundMC with inheritance 
/// from "Vehicle" base class from Bridge DLL
/// </summary>
public class OresundMC : Vehicle
{
    /// <summary>
    /// Initilizes a new instance of a OresundMC
    /// Date will always be set to the immediate day and time when initializing
    /// </summary>
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    /// <param name="brobizz">A boolean for wheter a Brobizz is included for discounts</param>
    public OresundMC(string licensePlate, bool brobizz) 
        : base(licensePlate, brobizz)
    {
    }

    /// <summary>
    /// Initializes a new instance of a OresundMC
    /// Date can be manually specified when initializing
    /// </summary>
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    public OresundMC(string licensePlate, DateTime date, bool brobizz) 
        : base(licensePlate, date, brobizz)
    {
    }

    /// <summary>
    /// Returns the price of a ticket as a double. Gives a % discount if boolean "Brobizz" is true.
    /// This Method is for Oresund MC's
    /// </summary>
    /// <returns>The total ticket price after applicable discount</returns>
    public override double Price()
    {
        double price = 235.0;

        if (Brobizz == true)
        {
            price = 92;
        }
        return price;
    }

    /// <summary>
    /// Returns vehicle type as a string for Oresund MC's
    /// </summary>
    /// <returns>The type of vehicle</returns>
    public override string VehicleType()
    {
        return "Oresund MC";
    }
}
