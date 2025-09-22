namespace Bridge;

/// <summary>
/// Class representing a car with a license plate and date
/// </summary>
public class Car : Vehicle
{
    /// <summary>
    /// Initializes a new instance of the Car class with license plate, and date
    /// and inherits from the vehicle base class
    /// </summary>
    /// <param name="licensePlate">A string consisting of numbers and letters</param>
    public Car(string licensePlate, DateTime date)
        : base(licensePlate, date)
    {
    }

    /// <summary>
    /// Returns fixed price as a double
    /// </summary>
    /// <returns>The price of the vehicle</returns>
    public override double Price()
    {
        return 230.0;
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
