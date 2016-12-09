using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A4
{
    interface Irefillable
    {
        float FuelPercentage { get; }

        void Refill(int amt);
        

        
    }
}
