using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A4
{
    class Program
    {
        static void Main(string[] args)
        {
            //All the Vessel Object Creations.
            Ship hoss = new Ship("Hoss", 4.7f, 10, 20);
            Ship boss = new Ship("Boss", 2f, 2, 5);
            Ship toss = new Ship("Toss", 13f, 0, 9);
            Ship noss = new Ship("Noss", .3f, 5, 0);
            Ship voss = new Ship("Voss", 5f, 10, 20);

            Boat nope = new Boat("Nope", 1, 0);
            Boat dope = new Boat("Dope", 1, 1);
            Boat grope = new Boat("Grope", 0, 10);
            Boat mope = new Boat("Mope", 2, 2);
            Boat pope = new Boat("Pope", 4, 6);

            Cat frank = new Cat(5, 10, "Frank");
            Cat cici = new Cat(10, 20, "CiCi");

            //List containing all vessels
            List<Vessel> fleet = new List<Vessel>();

            //Ship Adds
            fleet.Add(hoss);
            fleet.Add(boss);
            fleet.Add(toss);
            fleet.Add(noss);
            fleet.Add(voss);

            //Boat Adds
            fleet.Add(nope);
            fleet.Add(dope);
            fleet.Add(grope);
            fleet.Add(mope);
            fleet.Add(pope);

            Console.WriteLine();
            //for each loop to run through all the vessels and move them.
            foreach(Vessel vessel in fleet)
            {
                Console.WriteLine(vessel.ToString() + " Moving...");
                vessel.Move();
                Console.WriteLine();
                
            }


            //Prints to show before and after refills.
            Console.WriteLine("{1}'s Fuel Percentage Before Refill %{0}.", hoss.FuelPercentage, hoss.ToString());
            hoss.Refill(5);
            Console.WriteLine("{1}'s Fuel Percentage After Refill %{0}.", hoss.FuelPercentage, hoss.ToString());

            Console.WriteLine();

            Console.WriteLine("{1}'s Hunger Percentage Before being fed %{0}.", cici.FuelPercentage, cici.ToString());
            cici.Refill(5);
            Console.WriteLine("{1}'s Hunger Percentage After being fed %{0}.", cici.FuelPercentage, cici.ToString());
        }
    }
}
