using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan üçgenin kenar uzunluklarını al
            Console.Write("Birinci kenar uzunluğunu giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci kenar uzunluğunu giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü kenar uzunluğunu giriniz: ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            if (a + b > c && a + c > b && b + c > a)
            {
                if(a == b || a == c || b == c)
                {
                    Console.Write("Bu üçgen ikizkenar üçgendir!");
                }
                else if (a == b && b == c)
                {
                    Console.Write("Bu üçgen eşkenar üçgendir!");
                }
                else
                {
                    Console.Write("Bu üçgen çeşitkenar üçgendir!");
                }
            }
            else
            {
                Console.WriteLine();
                Console.Write("Bu kenar uzunlukları ile üçgen oluşturulamaz!");
                Console.WriteLine();
            }
        }
    }
}