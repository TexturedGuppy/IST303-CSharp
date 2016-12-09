using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A4
{
    class Cat : Irefillable
    {
        private int hunger;
        private int maxHunger;
        private string name;

        /// <summary>
        /// Cat constructor
        /// </summary>
        /// <param name="_hunger"></param>
        /// <param name="_maxhunger"></param>
        public Cat(int _hunger, int _maxhunger, string _name)
        {
            hunger = _hunger;
            maxHunger = _maxhunger;
            name = _name;
        }

        /// <summary>
        /// Gets the Fuel Percentage, and in the case, the cats hunger level.
        /// </summary>
        public float FuelPercentage
        {
            get
            {
                return ((float)hunger / (float)maxHunger) * 100;
            }
        }

        /// <summary>
        /// Function to Feed the Cat
        /// Inherited from our interface class
        /// </summary>
        /// <param name="amt"></param>
        public void Refill(int amt)
        {
            if (amt < 0)
            {
                amt = 0;
                hunger -= amt;
            }
            else if ((amt + hunger) > maxHunger)
            {
                amt = maxHunger - hunger;
                hunger -= amt;
                Console.WriteLine("Be careful, you don't want to overfeed the cat!");
            }

            else
            {
                hunger -= amt;

            }
            
        }

        public override string ToString()
        {
            return name;
        }

    }
}


                
