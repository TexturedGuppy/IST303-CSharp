using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A4
{
    class Boat : Vessel
    {
        private int oars;
        private float totalSpeed;
        public Boat(string _name, float _speed, int _oars) : base(_name, _speed)
        {
            if(_oars <= 0)
            {
                oars = 0;
                Console.WriteLine(name + ", You don't have any oars!");
            }
            else
            {
                oars = _oars;
            }
            totalSpeed = _speed * _oars;
        }

        public override string ToString()
        {
            return name;
        }

        public override void Move()
        {
            Console.WriteLine(name + " scooted through the water at " + totalSpeed + "scoots per second!");
        }
    }
}
