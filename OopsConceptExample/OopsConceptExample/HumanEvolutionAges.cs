using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    public class HumanEvolutionAges
    {
        public string rise; //This are class level variables
        public string dawn;
        public int year;
        public void Paleolithic() //This is non-parameterised method
        {
            string start = "2.5 million"; //This are method level variables
            string end = "10000 BC";
            Console.WriteLine($"Paleolithic age started {start} years ago till {end} ");
        }
        public void Mesolithic(string begining, string ending) //This is a parameterised method
        {
            Console.WriteLine($"Mesolithic age started from {begining} and ended at {ending}");
        }
        public void Neolithic(string evolve, string perish, int bronzeAgeYear) //This is a parameterised method
        {
            rise = evolve;
            dawn = perish;
            year = bronzeAgeYear;
            Console.WriteLine($"Neolithic age started from {rise} till {dawn}");
        }
        public int BronzeAge() //This is a non-parameterised method with return type int
        {
            Console.WriteLine($"Bronze age started from year {year} BC");
            return year;
        }
    }
}
