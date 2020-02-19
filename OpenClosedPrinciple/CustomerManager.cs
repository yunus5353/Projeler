using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
   public class CustomerManager
    {
        private IMevzuat _mevzuat;
        public CustomerManager(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }

        public void Add()
        {
            _mevzuat.İslemYap();
        }
    }
}
