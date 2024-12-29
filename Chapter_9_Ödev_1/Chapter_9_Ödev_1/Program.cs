using System;

namespace CalisanMaas
{
    // Enum yapısı oluşturuldu
    enum Calisanlar : byte
    {
        Idareci,   // 0 - 100 TL
        Ogretmen,  // 1 - 200 TL
        Memur,     // 2 - 300 TL
        Hizmetli   // 3 - 400 TL
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan tipini seçin:");
            Console.WriteLine("0 - Idareci");
            Console.WriteLine("1 - Ogretmen");
            Console.WriteLine("2 - Memur");
            Console.WriteLine("3 - Hizmetli");

            // Kullanıcıdan seçim alındı
            Console.Write("Seçiminizi yapınız (0-3): ");
            byte secim = byte.Parse(Console.ReadLine());

            // Enum türüne göre kullanıcı seçimi değerlendirildi
            Calisanlar calisan;
            if (Enum.IsDefined(typeof(Calisanlar), secim))
            {
                calisan = (Calisanlar)secim;
            }
            else
            {
                Console.WriteLine("Geçersiz bir seçim yaptınız!");
                return;
            }

            // Maaş bilgisi switch-case ile belirlendi
            int maas;
            switch (calisan)
            {
                case Calisanlar.Idareci:
                    maas = 100;
                    break;
                case Calisanlar.Ogretmen:
                    maas = 200;
                    break;
                case Calisanlar.Memur:
                    maas = 300;
                    break;
                case Calisanlar.Hizmetli:
                    maas = 400;
                    break;
                default:
                    Console.WriteLine("Geçersiz çalışan tipi.");
                    return;
            }

            // Maaş ekrana yazdırıldı
            Console.WriteLine($"{calisan} maaşı: {maas} TL");
        }
    }
}
