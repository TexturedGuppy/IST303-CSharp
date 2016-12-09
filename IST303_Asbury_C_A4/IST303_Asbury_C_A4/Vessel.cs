using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A4
{
    abstract class Vessel
    {
        //Variables that can be used by any class that is a child of this one.
        protected float speed;
        protected string name;

        /// <summary>
        /// Vessel Constructor, takes in the speed and name of the vessel and sets them both.
        /// </summary>
        /// <param name="_speed"></param>
        /// <param name="_name"></param>
        public Vessel(string _name, float _speed)
        {
            if (_speed < 0)
            {
                speed = 0;
            }
            else
            {
               name = _name;
               speed = _speed;
            }
        }

        /// <summary>
        /// Move Function for children to override.
        /// </summary>
        public virtual void Move()
        {
            Console.WriteLine("Vessel {0} has moved {1} units.", name, speed);
        }
    }
}
