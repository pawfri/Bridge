using System.Runtime.CompilerServices;

namespace Bridge;

/// <summary>
/// Class representing a car with a license plate and bridge ticket date
/// Inherits from the base class "Vehicle"
/// </summary>
public class Car : Vehicle
{
    /// <summary>
    /// Initilizes a new instance of a Car
    /// Date will always be set to the immediate day and time when initializing
    /// </summary>
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    /// <param name="brobizz">A boolean for wheter a Brobizz is included for discounts</param>
    public Car(string licensePlate, bool brobizz)
        : base(licensePlate, brobizz)
    {
    }

    /// <summary>
    /// Initializes a new instance of a Car
    /// Date can be manually specified when initializing
    /// </summary>
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    public Car(string licensePlate, DateTime date, bool brobizz)
        : base(licensePlate, date, brobizz)
    {
    }

    /// <summary>
    /// Returns the price of a ticket as a double. Gives a % discount if boolean "Brobizz" is true.
    /// </summary>
    /// <returns>The total ticket price after applicable discount</returns>
    public override double Price()
    {
        double price = 230.0;
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
        return "Car";
    }
}
