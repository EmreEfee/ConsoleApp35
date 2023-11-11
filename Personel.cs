using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Personel : Kisi
    {
        public int CalismaSaati { get; set; }
         public double Maas { get; set; }
        public void Yazdir()
        {


            Console.WriteLine("Personel Bilgileri");
            Console.WriteLine("-------------------");
            Console.WriteLine("Tam Ad: "+TamAd);
            Console.WriteLine("Çalışma Saati: "+CalismaSaati);
            Console.WriteLine("Maaş: "+Maas);

        }
    }
}
