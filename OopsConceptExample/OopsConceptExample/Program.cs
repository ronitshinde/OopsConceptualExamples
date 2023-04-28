using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle example = new Vehicle();  //Object : "example" is the object used to call the type members of the class.
            //Call First Method using "example" object.
            example.Drive("Buggati", "White");
            example.Drive("Ferrari", "Black");
            //Second Method using object (Parameterized)
            example.Brake("Disc Brake",007);
            example.Brake("Drum Brake",0077);
            //Third Method (non-parameterized with return type) using object
            Console.WriteLine($"Gears : {example.GearShift()}");
            Console.ReadKey();
        }
    }
}
