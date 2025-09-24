using System;
using Bridge;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary;

/// <summary>
/// Repository for StoreBaelt Vehicle tickets
/// </summary>
public class StoreBaeltRepository
{
    /// <summary>
    /// Static list to keep track of Vehicle tickets for StoreBaelt
    /// </summary>
    private static List<Vehicle> _tickets = new();

    /// <summary>
    /// Add new ticket for a Vehicle to the list
    /// </summary>
    /// <param name="vehicle">Vehicle to associate the ticket with</param>
    public static void AddTicket(Vehicle vehicle)
    {
        _tickets.Add(vehicle);
    }

    /// <summary>
    /// Get all tickets in the list for StoreBaelt
    /// </summary>
    /// <returns>Returns all tickets for every vehicles associated with StoreBaelt</returns>
    public static List<Vehicle> GetAll()
    {
        return _tickets;
    }

    /// <summary>
    /// Get all tickets for a single specific Vehicle
    /// </summary>
    /// <param name="licensePlate">The License Plate of the Vehicle</param>
    /// <returns></returns>
    public static List<Vehicle> GetTicketsLicensePlate(string licensePlate)
    {
        return _tickets.FindAll(tickets => tickets.LicensePlate == licensePlate);
    }
}
