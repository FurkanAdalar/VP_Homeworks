using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[20];

        // Kullanıcıdan 20 elemanı al
        Console.WriteLine("20 adet sayı giriniz:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Diziyi büyükten küçüğe sıralama
        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("\nBüyükten küçüğe sıralı liste:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // Aranacak elemanı kullanıcıdan al
        Console.WriteLine("\n\nAramak istediğiniz sayıyı giriniz:");
        int searchValue = int.Parse(Console.ReadLine());

        // Binary Search algoritması
        int resultIndex = BinarySearch(numbers, searchValue);

        // Sonucu yazdırma
        if (resultIndex != -1)
        {
            Console.WriteLine($"\n{searchValue} sayısı dizide bulundu. İndeksi: {resultIndex}");
        }
        else
        {
            Console.WriteLine($"\n{searchValue} sayısı dizide bulunamadı.");
        }
    }

    // Binary Search metodu
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Hedef değeri bulduysak
            if (arr[mid] == target)
                return mid;

            // Hedef değeri orta değerden küçükse
            if (arr[mid] < target)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1; // Hedef değeri bulamadıysak
    }
}
