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
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + 0.9, tankCapacity)
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
    }
}
