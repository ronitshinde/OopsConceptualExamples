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
   
}
