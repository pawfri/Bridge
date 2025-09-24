using Bridge;

namespace StoreBaeltTicketLibrary
{
    public interface IStoreBaeltRepository
    {
        static abstract void AddTicket(Vehicle vehicle);
        static abstract List<Vehicle> GetAll();
        static abstract List<Vehicle> GetTicketsLicensePlate(string licensePlate);
    }
}