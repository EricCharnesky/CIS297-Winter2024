using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_ObjectOrientedProgramming
{
    public class Vehicle
    {
        public double OdometerReadingInKilometers {  get; private set; }
        public string Make { get; } 
        public string Model { get; }
        public string Color { get; set; }

        private double _kilometersPerLiter;

        // private attribute backed property
        public double KilometersPerLiter
        {
            get
            {
                return _kilometersPerLiter;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _kilometersPerLiter = value;
            }
        }
        public double TankCapacityInLiters {  get; private set; }
        public double LitersInTank {  get; private set; }

        public Vehicle(string make, string model, string color, double kilometersPerLiter, double tankCapacityInLiters)
        {
            Make = make;
            Model = model;
            Color = color;
            KilometersPerLiter = kilometersPerLiter;
            if ( tankCapacityInLiters < 0)
            {
                tankCapacityInLiters = 0;
            }
            TankCapacityInLiters = tankCapacityInLiters;
            LitersInTank = 0;
        }

        public bool Drive(double kilometersToDrive)
        {
            if ( LitersInTank * KilometersPerLiter >= kilometersToDrive)
            {
                LitersInTank -= kilometersToDrive / KilometersPerLiter;
                OdometerReadingInKilometers += kilometersToDrive;
                return true;
            }
            return false;
        }

        public bool AddGas(double litersToAdd)
        {
            if ( LitersInTank + litersToAdd <= TankCapacityInLiters)
            {
                LitersInTank += litersToAdd;
                return true;
            }
            return false;
        }


    }
}
