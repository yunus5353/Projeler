using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bird bird = new Bird();
            //bird.Eat();
            //bird.Fly();
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Console.ReadLine();
        }
    }
}
