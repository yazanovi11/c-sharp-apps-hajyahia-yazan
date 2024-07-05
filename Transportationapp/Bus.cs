using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.Transportationapp
{
    public class Bus:PublicVehicle
    {
        private readonly int doors=0;
        private bool bellStop = false;

        public Bus()
        {
        }

        public Bus(int line, int id, int maxSpeed, int seats, int doors) : base(line, id, maxSpeed, seats)
        {
            this.doors = doors;
        }

        public override void setMaxSpeed(int value)
        {
            if (value <= 120 && value > 0)
                maxSpeed = value;
        }

        public virtual bool CalculateHasRoom()
        {
            if (Math.Round (Seats * 1.1) < CurrentPassengers)
                return true;
            return false;
        }

        public override void UploadPassengers(int passengers)
        {
            if (CalculateHasRoom() == false)
                return;
            if (passengers + CurrentPassengers <= (int)Math.Round(Seats*1.1))
                CurrentPassengers += passengers;
            else
            {
                RejecetedPassengers = Math.Abs(Seats - (CurrentPassengers + passengers));
                CurrentPassengers =(int)Math.Round(Seats*1.1);
            }
        }
    }
}
