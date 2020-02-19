using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Dog : IDog
    {
        public void Bark()
        {
            Console.WriteLine("Köpek havladı");
        }

        public void Eat()
        {
            Console.WriteLine("Köpek yemek yedi");
        }
    }
}
