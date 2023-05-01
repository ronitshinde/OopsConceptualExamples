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
        public string grains = "Wheat";
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
}
