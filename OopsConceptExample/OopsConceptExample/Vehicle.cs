using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    public class Vehicle   //Class : works as the blue print to create objects.
    {
        public string color;   //Variable : It works as the type member/attribute of the class.
        public string brakeType; //All this variables are the Class level scope variables.
        public string model;
        public int modelNumber;
        public void Drive(string carModel, string color)   //Method : works as the type member of the class.It is parameterized method.
        {
            model = carModel;
            this.color = color;
            Console.WriteLine($"This is the Drive method for a vehicle : {carModel} with {color} color");
        }
        internal void Brake(string brakeVarients, int modelNumber)
        {
            brakeType = brakeVarients;
            this.modelNumber = modelNumber;
            Console.WriteLine($"This {model} with model number {modelNumber} holds the {brakeType} variant");
        }
        public int GearShift()
        {
            int gearTransmission = 7;
            Console.WriteLine($"Lamborghini has {gearTransmission} gear transmission");
            return gearTransmission;
        }
    }
}
