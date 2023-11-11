using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Kullanici
    {
        // Propertyler sınıflar içerisinde bazı değişkenleri kısıtlamamızı sağlar.
        //Tam özelliklerde property yapısını kullanmanız için yardımcı bir field ' a
        // ihtiyacımız vardır.
        // Bu yardımcı sayesinde ilgili değeri class içerisinde tutabiliriz.

        // Full yapı propertyi kullanabilmemiz için propfull yazıp double tab 'a basınız.

        public string KullaniciAdi;

        private string _parola;

        public string ParolaTanimla
        {
            set { _parola = value; }

        }

        public void GirisYap(string kAdi, string parola)
        {
            if (kAdi==KullaniciAdi && parola==_parola)
            {
                Console.WriteLine("Giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya parola hatalı.");
            }



        }



    }
}
