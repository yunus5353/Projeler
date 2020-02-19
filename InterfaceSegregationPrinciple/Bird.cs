using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Bird : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Kuş uçtu");
        }

        public void Eat()
        {
            Console.WriteLine("Kuş yemek yedi");
        }
    }
}
