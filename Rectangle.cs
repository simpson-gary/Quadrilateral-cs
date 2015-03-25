//Developer 	Gary Simpson
//Date      	3-22-2015
//Name      	Program.cs
/*Purpose   	Text book exercise 10.7

				11.7 (Quadrilateral Inheritance Hierarchy) 
                   Write an inheritance hierarchy for classes Quadri- lateral, 
                   Trapezoid, Parallelogram, Rectangle and Square. 
               Use Quadrilateral as the base class of the hierarchy. Make the 
                   hierarchy as deep (i.e., as many levels) as possible. Specify the 
                   instance vari- ables, properties and methods for each class. The private 
                   instance variables of Quadrilateral should be the x–y coordinate pairs for 
                   the four endpoints of the Quadrilateral. Write an app that instantiates 
                   objects of your classes and outputs each object’s area (except Quadrilateral).     
*/
using System;

namespace Quadrilateral
{
    class Rectangle : Quadrilateral
    {

        private double area;
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, 
            double x4, double y4)
            :base(x1,y1, x2, y2, x3, y3,x4, y4)
        {
            calculateArea();
        }// end constructor

        public double Area
        {
            get
            {
                return area;
            }// end get
        }// end property Area

        public void calculateArea()
        {
            area = base.Side1Length * base.Side2Length;
        }// end method calculateArea

    }// end class Rectangle
}
