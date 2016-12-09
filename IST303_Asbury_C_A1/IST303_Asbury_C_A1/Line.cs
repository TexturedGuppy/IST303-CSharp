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
    class Line
    {
        //the a, b, and c of the standard form of a line ax + by = c
        //Given the automatic get set properties
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
       
        //private line class variables
        private double slope;
        private bool isVertical;
        private bool isHorizontal;

        //Default constructor
        public Line()
        {

        }

        //Constructor with the three variables in it
        public Line(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        //Method to determine if the two lines are perpindicular, parallel, or neither
        public string perpOrPar(Line line1, Line line2)
        {
            //Strings to return if one of the 3.
            string pd = "perpindicular.";
            string pr = "parallel.";
            string n = "neither perpindicular or parallel.";

            //Compares the lines to eachother to determine if one of the 3 options.
             if ((line1.isHorizontal == true && line2.isVertical == true)|| (line2.isHorizontal == true && line1.isVertical == true))
            {
                return pd;
            }

             if (line1.isVertical == true && line2.isVertical == true)
            {
                return pr;
            }

             else 
                return n;
        }

        //Method to find Y if given X.
        public double LineFindY(double x)
        {
            double y = 0;
            y = ((C - (A * x)) / B);
            return y;
        }
        //Method to find X if given Y.
        public double LineFindX(double y)
        {
            double x = 0;
            x = ((C - (B * y)) / A);
            return x;
        }

        //Method to determine if the line is vertical or horizontal
        public void isVertOrHorz()
        {
            //Set of if/else to make sure lines are given correct Horizontal or Vertical tags.
            if (B == 0)
            {
                isVertical = true;
            }
            if (A == 0)
            {
                isHorizontal = true;
                setSlope();
            }
            else
            {
                setSlope();
            }

        }

        //Method to set the slope variable
        //Made private as to not give user power to create false values.
        private void setSlope()
        {
            slope = (-1 * A) / B;
        }
        //Public method to allow user to return the value of the slope.
        public double getSlope()
        {
            return slope;
        }
        //Method that determines where the two lines intersect if they do intersect.
        //Could not get algorithm worked out myself, used another's help to determine the X value
        //https://www.topcoder.com/community/data-science/data-science-tutorials/geometry-concepts-line-intersection-and-its-applications/
        public void whereIntersect(Line line1, Line line2)
        {
            //local variables
            double x, y = 0;
            double a1, b1, c1, a2, b2, c2;
            
            //Contructor Variables
            a1 = line1.A;
            b1 = line1.B;
            c1 = line1.C;
            a2 = line2.A;
            b2 = line2.B;
            c2 = line2.C;

            //Algorithm to determine X value of line intersection.
            x = ((b2 * c1) - (b1 * c2)) / ((a1 * b2) - (a2 * b1));
            //Determines Y value of intersection once X value is found.
            y = line1.LineFindY(x);

            //Prints to the screen if lines intersect or not.
            if ((line1.isVertical && line2.isVertical) || (line1.isHorizontal && line2.isHorizontal) != true)
                Console.WriteLine("The two lines intersect at ({0},{1}).", x, y);

            else
                Console.WriteLine("Lines are parallel");
        }

                
    }

}
        


       

            


       


      

                

    


   
