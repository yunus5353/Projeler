using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class IkinciMevzuat : IMevzuat
    {
        public void İslemYap()
        {
            Console.WriteLine("İkinci mevzuata göre işlem yapıldı");
        }
    }
}
