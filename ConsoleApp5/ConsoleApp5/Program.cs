using System;

namespace MyApplication
{
    class Bilgi
    {
        public string Ad {  get; set; }
        public string SoyAd { get; set; }
        public int Numara { get; set; }

        public Bilgi(string ad, string soyad, int numara) 
        {
            Ad = ad;
            SoyAd = soyad;
            Numara = numara;
        }
    }
    class Bilgi_Cagir
    {
        private Bilgi bilgi;

        public Bilgi_Cagir(Bilgi bilgi)
        {
            this.bilgi = bilgi;
        }

        public void Yazdir()
        {
            Console.WriteLine($"Ad: {bilgi.Ad}");
            Console.WriteLine($"Soyad: {bilgi.SoyAd}");
            Console.WriteLine($"Numara: {bilgi.Numara}");
        }
    }

    class Program
    {
        static void Main()
        {
            Bilgi bilgi = new Bilgi("Furkan", "Adalar", 548520);
            Bilgi_Cagir bilgiCagir = new Bilgi_Cagir(bilgi);
            bilgiCagir.Yazdir();
        }
    }
}