using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin: ");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 45)
            {
                Console.WriteLine("Girilen sayi 45'e eşittir. 45 = {0}",sayi);
            }
            else if(sayi > 45)
            {
                Console.WriteLine("Girilen sayi 45'den büyüktür. {0} > 45",sayi);
            }
            else
            {
                Console.WriteLine("Girilen sayi 45'den küsüktür. {0} < 45",sayi);
            }

        }
    }
}