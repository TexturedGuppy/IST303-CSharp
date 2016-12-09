using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A4
{
    class Ship:Vessel,Irefillable
    {
        private int fuel;
        private int maxFuel;

        /// <summary>
        /// Returns the percent of fuel remaining in our ship
        /// </summary>
        public float FuelPercentage
        {
            
            get
            {
                return ((float)fuel / (float)maxFuel) * 100;
            }
        }

        /// <summary>
        /// Ship Constructor
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_speed"></param>
        /// <param name="_fuel"></param>
        /// <param name="_maxFuel"></param>
        public Ship(string _name, float _speed, int _fuel, int _maxFuel) : base(_name, _speed)
        {
            fuel = _fuel;
            maxFuel = _maxFuel;

            if(fuel < 0)
            {
                fuel = 0;
            }
            if(maxFuel <= 0)
            {
                maxFuel = 0;
                Console.WriteLine(name + " has a max fuel of 0, did the tank fall off?");
            }
            if (maxFuel < fuel)
            {
                Console.WriteLine(name + " it looks like you were trying to carry more fuel than your tank can hold, fixed that for you.");
                fuel = maxFuel;
            }

        }

        /// <summary>
        /// Function for refilling the ship back up
        /// Inherited from our interface class
        /// </summary>
        /// <param name="amt"></param>
        public void Refill(int amt)
        {
            

            if (amt < 0)
            {
                Console.WriteLine("You aren't allowed to siphon fuel!");
                amt = 0;
                fuel += amt;
            }
            else if ((amt + fuel) > maxFuel)
            {
                amt = maxFuel - fuel;
                fuel += amt;

            }
            else
            {
                fuel += amt;

            }
            
            
        }

        /// <summary>
        /// Overridden Move Function from Vessel inherited
        /// </summary>
        public override void Move()
        {
            if (maxFuel < 0)
            {
                Console.WriteLine(name + " must have lost his gas tank! He isn't moving anywhere!");
            }
            if(fuel > 0)
            {
                fuel--;
                Console.WriteLine(name + " has moved " + speed + "units through the water.");
            }
            else
            {
                Console.WriteLine(name + " has run out of fuel, it's time to fill up!");
            }
        }

        public override string ToString()
        {
            return name;
        }
     
    }
}
