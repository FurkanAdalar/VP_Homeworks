using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] list = new int[10]; // 10 elemanlı dizi oluşturuldu

            Console.WriteLine("10 elemanlı bir dizi giriniz:");

            // Kullanıcıdan dizinin elemanları alınıyor
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"Dizinin {i + 1}. elemanını girin: ");
                list[i] = int.Parse(Console.ReadLine());
            }

            ortalamaAl(list);
        }
        static void ortalamaAl(int[] list)
        {
            int toplam=0;
            for (int i = 0; i < list.Length; i++)
            {
                toplam += list[i]*list[i];
            }
            int ortalama;

            ortalama = toplam / list.Length;

            Console.WriteLine("Girilen elemanların kareleri toplamının ortalaması: {0}",ortalama);
            Console.WriteLine("List uzunluğu="+list.Length);
        }
    }
}
