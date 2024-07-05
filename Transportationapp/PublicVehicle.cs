using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.Transportationapp
{
    public class PublicVehicle
    {
       private int line;
       private int id;
       protected int maxSpeed=0;
       private int seats=0;
       private bool hasRoom = true;
       private int rejecetedPassengers;
       private int currentPassengers = 0;

        public PublicVehicle()
        {
        }

        public PublicVehicle(int line, int id)
        {
            this.line = line;
            this.id = id;
        }

        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.line = line;
            this.id = id;
            this.maxSpeed = maxSpeed;
            this.seats = seats;
        }

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int Seats { get => seats; set => seats = value; }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }
        public int RejecetedPassengers { get => rejecetedPassengers; set => rejecetedPassengers = value; }

        public virtual void setMaxSpeed(int value)
        {
            if (value < 40 && value > 0)
                maxSpeed = value;
        }

        public virtual bool CalculateHasRoom()
        {
            if (seats < currentPassengers)
                return true;
            return false;
        }

        public virtual void UploadPassengers(int passengers)
        {
            if (CalculateHasRoom() == false)
                return;
            if (passengers + currentPassengers <= seats)
                currentPassengers += passengers;
            else
            {
                rejecetedPassengers =Math.Abs( seats - (currentPassengers + passengers));
                currentPassengers = seats;
            }
        }

        public override string ToString()
        {
            return $"Line:{line},Id:{id},MaxSpeed:{maxSpeed},Seats:{seats}";
        }

    }
    
}
