using Bridge;

namespace StoreBaeltTicketLibrary;

/// <summary>
/// Library Class for StoreBaelt to expand upon the logic DLL from Bridge.
/// </summary>
public class StoreBaelt
{
    /// <summary>
    /// Returns the price of a ticket as a double with all valid discounts.
    /// Only Cars will get the special WeekendDiscount on top of the Brobizz discount.
    /// Brobizz discount still apply to all vehicles types.
    /// </summary>
    /// <param name="vehicle">The vehicle buying the ticket</param>
    /// <returns></returns>
    public static double WeekendDiscount(Vehicle vehicle)
    {
        double price = vehicle.Price();
        int discountPercent = 15;

        if (vehicle.VehicleType() == "Car" && 
            (vehicle.Date.DayOfWeek == DayOfWeek.Saturday || 
            vehicle.Date.DayOfWeek == DayOfWeek.Sunday))
        {
            price = price - (price * discountPercent / 100);
        }
        
        return price;
    }
}
