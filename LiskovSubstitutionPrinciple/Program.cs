using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Ferrari();
            car.Run();
            car.OpenAirConditioning();
            Console.ReadLine();
        }
    }
}
