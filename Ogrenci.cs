using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Ogrenci
    {
        public string Ad, Soyad;
        public double N1, N2, N3;

        public double NotOrtalamasi
        {
           get
            {
                return (N1 + N2 + N3)/3 ;


            }


        }



    }
}
