using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class SatisDanismani : Personel
    {
        public double prim { get; set; }
        // Miras alınan classlar içerisinde aynı işlemde bir metod varsa 
        //Classlara özgü bir metod olmasını istiyorsanız.
        //Bu metod içerisinde "new" ifadesini belirtmeniz gerekir.

        public double HakEdis { get { return Maas + prim; } }
        public new void Yazdir()
        {


            Console.WriteLine("Satış Danışmanı Bilgileri: ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Tam Ad: "+TamAd);
            Console.WriteLine("Çalışma Saati: "+ CalismaSaati);
            Console.WriteLine("Maaş: "+ Maas);
            Console.WriteLine("Prim: "+ prim);
            Console.WriteLine("Bu ayki Hakedişi: "+ HakEdis);
        }
    }
}
