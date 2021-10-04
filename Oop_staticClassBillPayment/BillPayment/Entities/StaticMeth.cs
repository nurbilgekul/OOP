using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPayment.Entities
{
    public static class StaticMeth
    {
        
        public static double ElektrikHesapla(int son, int ilk)
        {
           double miktar= (son -ilk) * 1.2;
            return miktar;
        }
        public static double DogalgazHesapla(int son, int ilk)
        {
            double miktar = (son - ilk) * 1.4;
            return miktar;
        }
        public static double SuHesapla(int son)
        {
            double miktar = son * 2.1;
            return miktar;
        }
        
    }
}
