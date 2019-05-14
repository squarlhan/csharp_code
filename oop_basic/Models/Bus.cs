using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace oop_basic.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);

            double freeSpace = this.TankCapacity - this.FuelQuantity;

            if (liters > freeSpace)
            {
                Console.WriteLine("Cannot fit fuel in tank");
                return;
            }

            this.FuelQuantity += liters;
        }

        public override void Drive(double km)
        {
            this.FuelConsumption += 1.4;
            base.Drive(km);
            this.FuelConsumption -= 1.4;
        }

        public void DriveEmpty(double km)
        {
            base.Drive(km);
        }
    }
}
