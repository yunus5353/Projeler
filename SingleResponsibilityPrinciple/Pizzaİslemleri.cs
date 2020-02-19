using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Pizzaİslemleri
    {
        public void Pisir(int sure)
        {
            //Sadece pizza pişirme işlemi
        }

        public void HamuruAc(int boyut)
        {
            //Sadece pizza hamuru acma islemleri
        }

        public Malzemeİslemleri Malzemeler { get; set; }
    }
}
