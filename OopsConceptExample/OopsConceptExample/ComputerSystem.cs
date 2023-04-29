using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    public class ComputerSystem
    {
        public string brandName; //This is class level variable
        public string company;
        public void OperatingSystems() //This is a method with no parameter
        {
            Console.WriteLine("iOS is the fastest operating system");
        }
        public void OperatingSystems(string pros) //This is a method with single parameter
        {
            string osName = pros; //This is method level variable
            brandName = pros;
            Console.WriteLine($"{brandName} is the highest secured operating system");
            Console.WriteLine("Operating system : " + osName);
        }
        public bool OperatingSystems(bool result) //This is a method with single parameter but different datatype
        {
            Console.WriteLine("Windows is largely used operating system : " + result);
            return result;
        }
        public void OperatingSystems(string companyName, int points) //This is a method with multi parameters
        {
            this.company = companyName;
            char[] characters = companyName.ToCharArray(); //Way to store string into char array -> cannot implicitly convert string to char
            foreach (char element in characters)  //Element : it is a block level variable
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("String company name : " + company);
        }
        public void OperatingSystems(int points, string companyName) //This is a method with multi parameters but with changed position 
        {
            Console.WriteLine($"{companyName} has the highest rating in terms of use having {points} points out of 10");
        }
    }
}
