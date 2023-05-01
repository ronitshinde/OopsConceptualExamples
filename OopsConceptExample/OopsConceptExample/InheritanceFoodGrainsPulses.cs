using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    //Single Level Inheritance
    public class InheritanceFoodGrainsPulses
    {
        public string grains;
        public void FoodGrains(string pulses)
        {
            Console.WriteLine("Food grains are an integral part of human diet");
            Console.WriteLine($"{pulses} are nutritious");
        }
    }
    public class Wheat : InheritanceFoodGrainsPulses
    {
        public string gram = "Bengal gram";
        public void Pulses()
        {
            Console.WriteLine($"{grains} is the mostly consumed grain");
            Console.WriteLine("Pulses are rich in protein");
        }
    }
    //Multilevel Inheritance
    public class Jowar : Wheat
    {
        //object of these class can be used to call methods and variables from both the classes
        public void JowarVariety()
        {
            //variables from both the classes are called in this method
            Console.WriteLine("This is the multilevel inheritance");
            Console.WriteLine($"{grains} and {gram} are the mostly consumed staple in Maharashtra");
        }
    }
    //Hierarchial Inheritance
    //Both classes inherit from the same base class
    public class Rice : InheritanceFoodGrainsPulses
    {
        public void RiceVariety(string riceType)
        {
            grains = riceType;
            Console.WriteLine("This quality of rice is mostly consumed in western maharashtra : " + grains);
        }
    }
    public class Bajra : InheritanceFoodGrainsPulses
    {
        public void BajraVariety(string area)
        {
            grains = area;
            Console.WriteLine("Bajra is consumed in areas of : " + grains);
        }
    }
    //Hybrid Inheritance
    //These is a combination of multilevel and hierarchical inheritance
    public class Oats : Jowar //Jowar is a hierarchial inherited class
    {
        public void OatsVariety()
        {
            Console.WriteLine("This is a hybrid inherited Class Oats");
        }
    }
    public class Rye : Jowar //Jowar is a hierarchial inherited class
    {
        public void RyeVariety()
        {
            Console.WriteLine("This is a hybrid inherited Class Rye");
        }
    }
}
