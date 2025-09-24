using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundsBronTicketLibrary;

public class OresundCar : Vehicle
{
    public OresundCar(string licensePlate, bool brobizz)
    : base(licensePlate, brobizz)
    {
    }

    public OresundCar(string licensePlate, DateTime date, bool brobizz)
        : base(licensePlate, date, brobizz)
    {
    }

    public override double Price()
    {
        double price = 460.0;

        if (Brobizz == true)
        {
            price = 178;
        }
        return price;
    }

    public override string VehicleType()
    {
        return "Oresund Car";
    }
}
