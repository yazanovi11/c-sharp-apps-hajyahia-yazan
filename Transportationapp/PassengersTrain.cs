﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_Masarwa_Shadi.TransportationApp
{
    public class PassengersTrain
    public class PassengersTrain:PublicVehicle
    {
        private Crone[] crones = null;
        private int cronesAmount = 0;

        public Crone[] Crones { get => crones; set => crones = value; }
        public int CronesAmount { get => cronesAmount; set => cronesAmount = value; }

        public override int MaxSpeed
        {
            set
            {
                int vehicleMaxSpeed = 300;
                if (value <= vehicleMaxSpeed && value > 0)
                    maxSpeed = value; ;
            }
        }
        public PassengersTrain()
        {
            CronesAmount = 0;
            Crones = null;
        }

        public PassengersTrain(int line, int id, int maxSpeed, int seats, Crone crone, int cronesAmount) : base(line, id, maxSpeed, seats)
        {
            Crone[] croneArray = new Crone[cronesAmount];
            for (int i = 0; i < cronesAmount; i++)
            {
                croneArray[i] = new Crone(crone);
            }
            Crones = croneArray;
            this.CronesAmount = cronesAmount;
            MaxSpeed = maxSpeed;
        }

        public override bool CalculateHasRoom()
        {
            if (GetEmptySeats() > 0)
                return true;
            return false;
        }

        private int GetEmptySeats()
        {
            int allSeats = 0;
            foreach(Crone c in Crones)
            {
                allSeats += c.GetSeats() + c.GetExtras();
            }
            return allSeats-CurrentPassengers;
        }
        public override void UploadPassengers(int passengers)
        {
            int emptySeats = GetEmptySeats();
            if (CalculateHasRoom() == false)
            {
                //Console.WriteLine("Train is full!!");
                return;
            }
            if (passengers + CurrentPassengers <= emptySeats)
            {
                CurrentPassengers += passengers;
                //Console.WriteLine("All passengers registered successfully!!");
            }
            else
            {
                RejectedPassengers = passengers- emptySeats; 
                CurrentPassengers += emptySeats;
                //Console.WriteLine($"{emptySeats} were registred, {RejectedPassengers} were rejected!!");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Crones: {CronesAmount}";
        }

    }
}
