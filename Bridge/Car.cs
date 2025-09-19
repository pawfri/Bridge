namespace Bridge;

/// <summary>
/// Class representing a car with a license plate and date
/// </summary>
public class Car : Vehicle
{
    public string Licenseplate { get; set; }

    /// <summary>
    /// Initializes a new instace of the Car class with license plate, and date
    /// and inherits from the vehicle base class
    /// </summary>
    /// <param name="licenseplate">A string consisting of numbers and letters</param>
    public Car(string licenseplate, DateTime date)
        : base(date)
    {
        Licenseplate = licenseplate;
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
