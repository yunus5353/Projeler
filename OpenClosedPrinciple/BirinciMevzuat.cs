using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class BirinciMevzuat : IMevzuat
    {
        public void İslemYap()
        {
            Console.WriteLine("Birinci mevzuata göre işlem yapıldı");
        }
    }
}
