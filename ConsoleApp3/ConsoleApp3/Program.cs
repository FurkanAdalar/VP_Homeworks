using System;

namespace DataTypeCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType().ToString());

            var str = "Hello World";
            Console.WriteLine("Type of str is {0}", str.GetType().ToString());

            var d = 10.50d;
            Console.WriteLine("Type of d is {0}", d.GetType().ToString());

        }
    }
}