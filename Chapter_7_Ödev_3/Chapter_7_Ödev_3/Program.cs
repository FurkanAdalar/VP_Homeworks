using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                if(i == 60)
                {
                    break;
                }
                else if(i % 2 == 0)
                {
                    Console.Write(" {0}",i);
                }

            }
        }
    }
}