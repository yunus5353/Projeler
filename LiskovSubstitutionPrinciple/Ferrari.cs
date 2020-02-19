using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Ferrari : Car
    {
        public override void OpenAirConditioning()
        {
            Console.WriteLine("Ferraride klimalar çalıştı");
        }
    }
}
