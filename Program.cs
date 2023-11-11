using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {

            //Şimdiki zamanı öğrenmek için DateTime.Now ifadesini kullanın.
            /*
            DateTime tarih = DateTime.Now;
            Console.WriteLine("Şimdiki zaman: " + tarih);
            Console.WriteLine("Tarih bilgisi: " + tarih.Date);
            Console.WriteLine("Gün Bilgisi: " + tarih.Day);
            Console.WriteLine("Ay Bilgisi: " + tarih.Month);
            Console.WriteLine("Yıl Bilgisi: " + tarih.Year);
            Console.WriteLine("Saat Bilgisi: " + tarih.Hour);
            Console.WriteLine("Dakika Bilgisi: " + tarih.Minute);
            Console.WriteLine("Saniye bilgisi: " + tarih.Second);
            Console.WriteLine("Milisaniye bilgisi: "+tarih.Millisecond);


            // DayOfWeek => Haftanın gün bilgisini ingilizce olarak döndürür.
            Console.WriteLine("Haftanın hangi günü: "+tarih.DayOfWeek);
            Console.WriteLine("Yılın kaçıncı günü: "+tarih.DayOfYear);
            Console.WriteLine("Uzun tarih bilgisi: "+tarih.ToLongDateString());
            Console.WriteLine("Kısa tarih bilgisi: "+tarih.ToShortDateString());
            Console.WriteLine("Uzun saat bilgisi: "+tarih.ToLongTimeString());
            Console.WriteLine("Kısa saat bilgisi: "+tarih.ToShortTimeString());
            Console.WriteLine();
            //ToString() metodu ile tarih formatı yazdırma.

            Console.WriteLine("Gün: "+tarih.ToString("dd"));
            Console.WriteLine("Kısa Gün: "+tarih.ToString("ddd"));
            Console.WriteLine("tam Gün: " + tarih.ToString("dddd"));
            Console.WriteLine("Ay: "+tarih.ToString("MM"));
            Console.WriteLine("Kısa Ay: "+tarih.ToString("MMM"));
            Console.WriteLine("Tam Ay: "+tarih.ToString("MMMM"));
            Console.WriteLine("Yıl: "+tarih.ToString("yyyy"));
            Console.WriteLine("Kısa Yıl: " + tarih.ToString("yy"));

            // hh => 12 saatlik dilim, HH => 24 saatlik dilim

            Console.WriteLine("Saat: "+tarih.ToString("hh:tt")); // tt öğleden önce veya sonra durumunu belirtir
            Console.WriteLine("Saat: "+tarih.ToString("HH"));
            Console.WriteLine("Dakika: " + tarih.ToString("mm"));
            Console.WriteLine("Saniye: " + tarih.ToString("ss"));
            Console.WriteLine("Milisaniye: "+tarih.ToString("fff"));


            Console.WriteLine("Tarih formatı: "+tarih.ToString("dd MMMM yyyy HH:mm"));
            Console.WriteLine("Tarih formatı: " + tarih.ToString("MM dd yyyy"));
            Console.WriteLine();


            DateTime tarih2 = new DateTime(2021, 5, 25, 21, 34, 56);

            Console.WriteLine("Tarih: "+tarih2);
            //Tarih üzerine veri ekleme 

            Console.WriteLine("+5 dakika: "+tarih2.AddMinutes(5));
            Console.WriteLine("-5 dakika: " + tarih2.AddMinutes(-5));
            Console.WriteLine("+10 saat: " + tarih2.AddHours(10));
            Console.WriteLine("-10 saat: " + tarih2.AddHours(-10));
            Console.WriteLine("+5 Yıl: "+tarih2.AddYears(5));
            Console.WriteLine("-5 Yıl: " + tarih2.AddYears(-5));

            Console.WriteLine();

            //String bir değeri DateTime formatına çevirelim.


            DateTime tarih3 = DateTime.Parse("12.04.2019 14:45:19");
            Console.WriteLine("Tarih Bilgisi: "+tarih3.ToShortDateString());
            Console.WriteLine("Saat bilgisi: "+tarih3.ToShortTimeString());
            */

            //PROPERTY'LER 
            // Class yapıları içerisinde tanımlanan bazı değişkenlerin sadece okunabilir veya sadece yazılabilir
            // isteyebiliriz.
            //Tanımlanan değişkenlerin yanında(get; set;)
            // değerlerini belirtiriz.
            // get => sadece okunabilir.
            // set => sadece yazılabilir
            //manasına 
            //Bu sayede erişilmesini istemediğimiz bir veriye ulaşımı kısı
            //property'ler içerisinde get ve set alanlarına {} blok alanla
            // istediğiniz işlemleri yaptırabilirisiniz.
            /*
            Ogrenci o = new Ogrenci();

            o.Ad = "Ali";
            o.Soyad = "Polat";
            o.N1 = 67;
            o.N2 = 86;
            o.N3 = 76;

            Console.WriteLine("Adı: " + o.Ad);
            Console.WriteLine("Soyadı: " + o.Soyad);
            Console.WriteLine("1. Not: " + o.N1);
            Console.WriteLine("2. Not: " + o.N2);
            Console.WriteLine("3. Not: "+ o.N3);
            Console.WriteLine("Not Ortalaması: " + o.NotOrtalamasi);
            */
            /*
            int sayi1, sayi2, sayi3;
            Console.WriteLine("Sayı 1 i giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 2 i giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 3 ü giriniz: ");
            sayi3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Birinci sayı: " + sayi1);
            Console.WriteLine("İkinci sayı: " + sayi2);
            Console.WriteLine("Üçüncü sayı: " + sayi3);
            */

            /*
            Kullanici k = new Kullanici();

            k.KullaniciAdi = "ahmet";
            k.ParolaTanimla="123";

            k.GirisYap("ahmet", "123");
            */



            // Interitance (Kalıtım)

            // C# programlama dili içerisinde birden fazla class yazılabilir, bu classlar
            //içerisinde bazı propertylerin özellikleri aynı olabilir.
            // Böyle bir durum ile karşılaştığımız zaman Kalıtım(Miras) alma durumu devreye girer
            //Bir Class  başka bir class' ı miras alabilir, miraz aldığınız class içerisinde
            //diğer clas ' ın tüm özelliklerini kullanabiliriz. 
            // Bir class ' a sadece bir class miras verebilir.!!!

            Personel p = new Personel();

            p.Ad = "Ali";
            p.SoyAd = "Kaçar";
            p.CalismaSaati = 160;
            p.Maas = 11250;
            p.Yazdir();


            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            SatisDanismani s = new SatisDanismani();

            s.Ad = "Ayşe";
            s.SoyAd = "Satar";
            s.CalismaSaati = 160;
            s.Maas = 11250;
            s.prim = 2250;
            s.Yazdir();
            

            Console.ReadKey();
        }
    }
}
