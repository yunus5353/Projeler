using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class Car
    {
        public void Run()
        {
            Console.WriteLine("Araba çalıştırıldı");
        }
        public abstract void OpenAirConditioning();
    }
}
