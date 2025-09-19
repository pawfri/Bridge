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

}
