using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundsBronTicketLibrary;

public class OresundMC : Vehicle
{
    public OresundMC(string licensePlate, bool brobizz) 
        : base(licensePlate, brobizz)
    {
    }

    public OresundMC(string licensePlate, DateTime date, bool brobizz) 
        : base(licensePlate, date, brobizz)
    {
    }

    public override double Price()
    {
        double price = 235.0;

        if (Brobizz == true)
        {
            price = 92;
        }
        return price;
    }

    public override string VehicleType()
    {
        return "Oresund MC";
    }
}
