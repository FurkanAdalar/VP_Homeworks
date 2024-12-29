using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] list = new int[10] { 34, 72, 13, 44, 25, 30, 10, 23, 9, 43 };
            int[] temp = list;

            Console.Write("Original Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Sort the array
            Array.Sort(list);
            Console.Write("Sorted Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Kullanıcının istediği elemanı seçme kısmı
            Console.Write("Lütfen 0 ile 9 arasında bir indeks girin: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < list.Length)
            {
                Console.WriteLine("Seçtiğiniz eleman: {0}", list[index]);
            }
            else
            {
                Console.WriteLine("Geçersiz indeks! Lütfen 0 ile 9 arasında bir sayı girin.");
            }
        }
    }
}
