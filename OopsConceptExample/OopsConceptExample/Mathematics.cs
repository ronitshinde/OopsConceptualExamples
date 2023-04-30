using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    public abstract class Mathematics  //This is an abstract class with abstract keyword -> object cannot be created
    {
        public string theorem;   //This are class level variables
        public double length, breadth;
        public abstract void Geometry(); //This is a abstract method with no body->Data is hidden
        public double Algebra(int length, int breadth, string theorem) //This is a non-abstract method with body
        {
            this.theorem = theorem;
            this.length = length;
            this.breadth = breadth;
            double multiplication;   //This is method level variable
            multiplication = length * breadth;
            return multiplication;
        }
    }
    public class Calculation : Mathematics //Class mathematics is inherited into derived class calculation
    {
        public override void Geometry() //This is the implemention of abstract method
        {
            double constant = 0.5; //This is a method level variable
            double areaOfTriangle, areaOfSquare, areaOfRectangle;
            areaOfTriangle = constant * length * breadth;
            areaOfSquare = length * length;
            areaOfRectangle = length * breadth;
            Console.WriteLine("Area of triangle : " + areaOfTriangle);
            Console.WriteLine("Area of square : " + areaOfSquare);
            Console.WriteLine("Area of rectangle : " + areaOfRectangle);
            Console.WriteLine("This is a theorem : " + theorem);
            Console.WriteLine("This is a abstract method");
        }
    }
}

