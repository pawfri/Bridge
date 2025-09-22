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
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    /// <param name="date">Date associated with the motorcycle</param>
    public MC(string licensePlate, DateTime date, bool brobizz)
        : base(licensePlate, date, brobizz)
    { 
    }

    /// <summary>
    /// Returns the price of a ticket as a double. Gives a % discount if Brobizz is true.
    /// </summary>
    /// <returns>The total ticket price after applicable discount</returns>
    public override double Price()
    {
        double price = 120.0;
        int discountPercent = 10;

        if (Brobizz == true)
        {
            price = price - (price * discountPercent / 100);
        }
        return price;
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
