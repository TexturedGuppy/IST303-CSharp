//Cameron Asbury
//C# Assignment 1
//File 1 of 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variables
            double xValue1 = 5;
            double yValue1 = 3;

            double xValue2 = 4;
            double yValue2 = 7;

            //Our two lines to compare to eachother.
            Line line1 = new Line(4,5,6);
            Line line2 = new Line(2,4,7);

            //Extra Line type in order to compare in the background.
            Line compare = new Line();


            //Methods being used and/or printed to screen.
            Console.WriteLine("The X value for line 1 when Y = {0} is {1}", yValue1, line1.LineFindX(xValue1));
            Console.WriteLine("The X value for line 2 when Y = {0} is {1}", yValue2, line2.LineFindX(xValue2));

            Console.WriteLine("The Y value for line 1 when X = {0} is {1}", xValue1, line1.LineFindY(yValue1));
            Console.WriteLine("The Y value for line 2 when X = {0} is {1}", xValue2, line2.LineFindY(yValue2));

            line1.isVertOrHorz();
            line2.isVertOrHorz();
            Console.WriteLine("The slope for line 1 is {0}",line1.getSlope());
            Console.WriteLine("The slope for line 2 is {0}",line2.getSlope());

            Console.WriteLine("Line 1 and Line 2 are {0}", compare.perpOrPar(line1, line2));

            compare.whereIntersect(line1,line2);

        }
    }
}
