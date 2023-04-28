using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    //This is Inheritance : using properties of parent class/base class to the child class.
    public class HeavyVehicles //This is parent/base class.
    {
        public string modelName;
        public int modelNum;
        public int wheels;
        public string intensity;
        public string enginePosition = "Front";
        public int fuelCapacity = 100;
        public void CarbonEmissions(string modelName, int modelNum, int wheels, string intensity)
        {
            this.modelName = modelName;
            this.modelNum = modelNum;
            this.wheels = wheels;
            Console.WriteLine($"{modelName} heavy vehicle with model number : {modelNum} and {wheels} wheels has the {intensity} carbon emissions");
        }
    }
    public class TransportRoutes : HeavyVehicles   //TransportRoutes is derived class and inherited properties from HeavyVehicles class.
    {
        string distance;
        public void Transport(string distance)
        {
           this.distance = distance;
            Console.WriteLine($"{enginePosition} engine position trucks have {distance} routes");
            Console.WriteLine($"Trucks with fuel capacity more than {fuelCapacity} liters are good for {distance} routes");
            Console.WriteLine("Engine Position variable inherited in TransportRoutes class : "+ enginePosition);
            Console.WriteLine("Same for fuelCapacity : "+ fuelCapacity);
        }
    }
}
