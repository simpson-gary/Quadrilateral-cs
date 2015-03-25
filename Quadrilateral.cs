//Developer 	Gary Simpson
//Date      	3-22-2015
//Name      	Quadrilateral.cs
/*Purpose   	Text book exercise 10.7

				11.7 (Quadrilateral Inheritance Hierarchy) 
                   Write an inheritance hierarchy for classes Quadri- lateral, 
                   Trapezoid, Parallelogram, Rectangle and Square. 
               Use Quadrilateral as the base class of the hierarchy. Make the 
                   hierarchy as deep (i.e., as many levels) as possible. Specify the 
                   instance variables, properties and methods for each class. The private 
                   instance variables of Quadrilateral should be the x–y coordinate pairs for 
                   the four endpoints of the Quadrilateral. Write an app that instantiates 
                   objects of your classes and outputs each object’s area (except Quadrilateral).     
*/
using System;

namespace Quadrilateral
{
    class Quadrilateral : object
    {
        private double x1, y1,
                    x2, y2,
                    x3, y3,
                    x4, y4;
        private double side1Length,
                       side2Length,
                       side3Length,
                       side4Length;

        public Quadrilateral(double x1,double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
        this.x1 =x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
        this.x4 = x4;
        this.y4 = y4;
        side1Length = Side1Length;
        side2Length = Side2Length;
        side3Length = Side3Length;
        side4Length = Side4Length;
        }// end Constructor   

        public double X1
        {
            get
            {
            return x1;
            }// end get
            set
            {
                x1 = value;
            }// end set
        }//end property x1
        public double Y1
        {
            get
            {
                return y1;
            }// end get
            set
            {
                y1 = value;
            }// end set
        }//end property y1
        public double X2
        {
            get
            {
                return x2;
            }// end get
            set
            {
                x2 = value;
            }// end set
        }//end property x2
        public double Y2
        {
            get
            {
                return y2;
            }// end get
            set
            {
                y2 = value;
            }// end set
        }//end property y2
        public double X3
        {
            get
            {
                return x3;
            }// end get
            set
            {
                x3 = value;
            }// end set
        }//end property x3
        public double Y3
        {
            get
            {
                return y3;
            }// end get
            set
            {
                y3 = value;
            }// end set
        }//end property y3
        public double X4
        {
            get
            {
                return x4;
            }// end get
            set
            {
                x4 = value;
            }// end set
        }//end property x4
        public double Y4
        {
            get
            {
                return y4;
            }// end get
            set
            {
                y4 = value;
            }// end set
        }//end property y4

        public double Side1Length
        {
            get
            {
                side1Length = Math.Sqrt( Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) );
                return side1Length;
            }// end get
        }//end property Side1length

        public double Side2Length
        {
            get
            {
                side2Length = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                return side2Length;
            }// end get
        }//end property Side2length

        public double Side3Length
        {
            get
            {
                side3Length = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
                return side3Length;
            }// end get
        }//end property Side3length

        public double Side4Length
        {
            get
            {
                side4Length = Math.Sqrt(Math.Pow((x1 - x4), 2) + Math.Pow((y1 - y4), 2));
                return side4Length;
            }// end get
        }//end property Side1length


    }// end class Quadrilateral
}
