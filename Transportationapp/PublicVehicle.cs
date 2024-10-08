﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.Transportationapp
{
    public class PublicVehicle
    {
        private int line = 0;
        private int id = 0;
        protected int maxSpeed = 0;
        private int seats = 0;
        private int currentPassengers = 0;
        private int rejectedPassengers = 0;
        private bool hasRoom = true;

        public PublicVehicle()
        {
            line = 0;
            id = 0;
            maxSpeed = 0;
            seats = 0;
            currentPassengers = 0;
            rejectedPassengers = 0;
            hasRoom = true;
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
            this.seats = seats;
            MaxSpeed = maxSpeed;
        }

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public virtual int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                int vehicleMaxSpeed = 40;
                if (value <= vehicleMaxSpeed && value > 0)
                    maxSpeed = value;
            }
        }
        public int Seats { get => seats; set => seats = value; }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int RejectedPassengers { get => rejectedPassengers; set => rejectedPassengers = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }

        public virtual void CalculateHasRoom()
        {
            if (seats > currentPassengers)
                HasRoom = true;
            else
                HasRoom = false;
        }
        protected void ProcessNegativePassengers(int passengers)
        {
            if (Math.Abs(passengers) <= CurrentPassengers)
            {
                CurrentPassengers += passengers;
                HasRoom = true;
                return;
            }
            else
            {
                CurrentPassengers = 0;
                HasRoom = true;
                return;
            }
        }
        public virtual void UploadPassengers(int passengers)
        {
            if (passengers < 0)
            {
                ProcessNegativePassengers(passengers);
                return;
            }
            CalculateHasRoom();
            if (!HasRoom)
            {
                //Console.WriteLine("Vehicle is Full!!");
                return;
            }
            if (passengers + currentPassengers <= seats)
                currentPassengers += passengers;
            else
            {
                rejectedPassengers = Math.Abs(seats - (currentPassengers + passengers));
                currentPassengers = seats;
            }
            if (currentPassengers == seats)
                HasRoom = false;
        }

        public override string ToString()
        {
            return $"Vehicle: {this.GetType().Name}, Line: {line}, Id: {id}, MaxSpead: {maxSpeed}, Seats: {seats}, Passengers: {CurrentPassengers}";
        }


    }
}