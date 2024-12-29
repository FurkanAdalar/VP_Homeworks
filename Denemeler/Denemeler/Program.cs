using System;

namespace SquareCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = 5; // Karenin bir kenar uzunluğu
            int area;
            int volume;

            // Alanı hesapla (ref ile)
            CalculateArea(ref side, out area);
            Console.WriteLine("Karenin Alanı: " + area);

            // Hacmi hesapla (out ile)
            CalculateVolume(side, out volume);
            Console.WriteLine("Karenin Hacmi: " + volume);
        }

        // Karenin alanını hesaplayan fonksiyon (ref ile)
        static void CalculateArea(ref int side, out int area)
        {
            area = side * side;
        }

        // Karenin hacmini hesaplayan fonksiyon (out ile)
        static void CalculateVolume(int side, out int volume)
        {
            volume = side * side * side;
        }
    }
}
