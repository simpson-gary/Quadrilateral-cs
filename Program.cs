//Developer 	Gary Simpson
//Date      	3-22-2015
//Name      	Program.cs
/*Purpose   	Text book exercise 10.7

				11.7 (Quadrilateral Inheritance Hierarchy) 
                   Write an inheritance hierarchy for classes Quadrilateral, 
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
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(-4, 2, 4, 2, 4, -2, -4, -2);
            Console.WriteLine("The area of the rectangle is {0}", rectangle.Area);

            Square square = new Square(-2, 2, 2, 2, 2, -2, -2, -2);
            Console.WriteLine("The area of the square is {0}", square.Area);

            Parallelogram parallelogram = new Parallelogram(1, 2.6, 4, 2, 4, .6, 1, 1);
            Console.WriteLine("The area of the parallelogram is {0}", parallelogram.Area);

            Trapezoid trapezoid = new Trapezoid(-7, -2, -4, -2, -2, -5, -9, -5);
            Console.WriteLine("The area of the trapzeoid is {0}", trapezoid.Area);


            Console.ReadLine();//added per instructions to halt execution
        }//end method Main
    }// end class Program
}
