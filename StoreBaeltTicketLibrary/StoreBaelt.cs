using Bridge;

namespace StoreBaeltTicketLibrary;

public class StoreBaelt
{
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
