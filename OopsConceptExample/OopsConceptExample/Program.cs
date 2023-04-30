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
            Console.WriteLine("Select the concept");
            Console.WriteLine("1.Object And Class\n2.Inheritance\n3.Method Overloading\n4.Method Overridding\n5.Encapsulation");
            Console.Write("Enter the number : ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (count)
            {
                case 1:
                    VehicleClass example = new VehicleClass();  //Object : "example" is the object used to call the type members of the class.
                                                                //Call First Method using "example" object.
                    example.Drive("Buggati", "White");
                    example.Drive("Ferrari", "Black");
                    //Second Method using object (Parameterized)
                    example.Brake("Disc Brake", 007);
                    example.Brake("Drum Brake", 0077);
                    //Third Method (non-parameterized with return type) using object
                    Console.WriteLine($"Gears : {example.GearShift()}");
                    Console.ReadKey();
                    return;
                case 2:
                    //Calling type members of base class using child class object.
                    TransportRoutes routes = new TransportRoutes();
                    routes.CarbonEmissions("Ashok Leyland", 7451, 14, "HIGHEST");
                    routes.CarbonEmissions("Eicher", 6142, 12, "LOWEST");
                    routes.Transport("LONGER");
                    routes.Transport("SHORTER");
                    Console.WriteLine();
                    Console.ReadKey();
                    return;
                case 3:
                    //Calling overloaded methods
                    ComputerSystem system = new ComputerSystem();
                    system.OperatingSystems();
                    system.OperatingSystems(true);
                    system.OperatingSystems("Linux");
                    system.OperatingSystems(9, "Windows");
                    system.OperatingSystems("Windows", 9);
                    Console.ReadLine();
                    return;
                case 4:
                    //Calling overridden methods
                    //1)Way to call overiding methods
                    ModernComputerSystems modern = new ModernComputerSystems();
                    modern.OperatingSystems();
                    modern.OperatingSystems("Windows");
                    modern.OperatingSystems(true);
                    modern.OperatingSystems(7, "Apple");
                    Console.WriteLine("Result in program.cs : " + modern.OperatingSystems(true));
                    //2)Other way to call overiding methods
                    ComputerSystem systems = new ModernComputerSystems();
                    systems.OperatingSystems();
                    ComputerSystem com = new ComputerSystem();
                    com = new ModernComputerSystems();
                    com.OperatingSystems();
                    //Method hiding
                    modern.OperatingSystems(7, "Linux");
                    Console.ReadLine();
                    return;
                case 5:
                    BooksType encapsulation = new BooksType();
                    encapsulation.Novel = "The Yogi";
                    encapsulation.Comics = "Seven Musketers";
                    encapsulation.Rating = 9;
                    encapsulation.NovelMethod();
                    Console.ReadLine();
                    return;
            }
        }
    }
}
