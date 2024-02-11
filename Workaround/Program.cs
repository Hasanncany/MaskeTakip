using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer("Hasan");
            SelamVer("Engin");
            SelamVer("Can");
            SelamVer();

            Topla(3,5);
            int sonuc = Topla(10,5);

            // Diziler - Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Hasan";
            ogrenciler[1] = "Caan";
            ogrenciler[2] = "Yıldırım";
            // ogrenciler[3] = "Engin";
            // ogrenciler[4] = "Demiroğ";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            // Referans Tipler 'NEW' STRING! 
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            Console.WriteLine(sehirler2[0]);
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            // Değer Tipler (Int, Double-Float, Bool)
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);


            // Foreach Döngüsü
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);    
            }

            // <List>
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            Console.ReadLine();
        }

        static void SelamVer(string isim = "İsimsiz!")
        {
            Console.WriteLine("Selamlar " + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " +  sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisDurumu = false;

            string ad = "Hasancan";
            string soyad = "Yıldırım";
            int dogumYili = 1999;
            long tcNo = 1234567890;


            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public int Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}