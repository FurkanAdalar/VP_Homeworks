using System;
using System.Collections.Generic;
using System.Linq;

//Kullanıcı adı soyadı ve doğum tarihlerinden oluşan  10 elemanlı bir list yapısı hazırlayınız
// Buradaki kişilerin doğum tarihlerine göre yaşlarını hesaplayıp,
// listeyi küçükten büyüğe sıralayan programı yazınız.
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDate.Year;
        if (BirthDate > today.AddYears(-age)) age--;
        return age;
    }
}

public class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { FirstName = "Ali", LastName = "Yılmaz", BirthDate = new DateTime(1995, 5, 12) },
            new Person { FirstName = "Ayşe", LastName = "Demir", BirthDate = new DateTime(2000, 8, 23) },
            new Person { FirstName = "Fatma", LastName = "Çelik", BirthDate = new DateTime(1985, 2, 15) },
            new Person { FirstName = "Mehmet", LastName = "Kaya", BirthDate = new DateTime(1970, 12, 10) },
            new Person { FirstName = "Can", LastName = "Arslan", BirthDate = new DateTime(1990, 6, 5) },
            new Person { FirstName = "Emine", LastName = "Aydın", BirthDate = new DateTime(1988, 11, 28) },
            new Person { FirstName = "Murat", LastName = "Öztürk", BirthDate = new DateTime(1993, 1, 30) },
            new Person { FirstName = "Zeynep", LastName = "Güneş", BirthDate = new DateTime(1998, 7, 14) },
            new Person { FirstName = "Ahmet", LastName = "Bozkurt", BirthDate = new DateTime(1975, 4, 20) },
            new Person { FirstName = "Elif", LastName = "Kara", BirthDate = new DateTime(2001, 9, 19) }
        };

        // Kişileri yaşlarına göre küçükten büyüğe sıralama
        var sortedPeople = people.OrderBy(p => p.GetAge()).ToList();

        // Sıralanmış listeyi yazdırma
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} - Yaş: {person.GetAge()}");
        }
    }
}
