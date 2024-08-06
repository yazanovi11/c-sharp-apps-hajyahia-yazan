using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c-sharp-apps-hajyahia-yazan.Transportationapp
{
    internal class Driver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public CargoType Type { get; set; }

        public void Approve(CargoVehicle vehicle)
        {
            vehicle.CanTravel = true;
        }

    }
    public enum CargoType
    {
        PrivateCar,
        Motorcycle,
        Truck,
        Plane,
        Train,
        Ship
    }

}


