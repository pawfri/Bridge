namespace Bridge;

/// <summary>
/// Class representing a car with a license plate and date
/// </summary>
public class Car
{
    public string Licenseplate { get; set; }
    public DateTime Date { get; set; }

    /// <summary>
    /// Initializes a new instace of the Car class with license plate and date
    /// </summary>
    /// <param name="licenseplate">A string consisting of numbers and letters</param>
    /// <param name="date">Date associated with the car</param>
    public Car(string licenseplate, DateTime date)
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
        return 230.0;
    }

    /// <summary>
    /// Returns vehicle type as a string
    /// </summary>
    /// <returns>The type of vehicle</returns>
    public string VehicleType()
    {
        return "Car";
    }
}
