using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace findingElementOfItemInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will do the array stuff for you");
            Random rnd = new Random();
            int j = 10;
            int[] numbers = new int[j];
            for (int i = 0; i < j; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }
            int chosen = rnd.Next(0, j - 1);
            Console.WriteLine($"{chosen} index has value {numbers[chosen]}");

            //doing this to just make it seem like it takes time to find the number
            string finding = "finding...";
            foreach (var c in finding)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }

            Console.WriteLine($"{numbers[chosen]} has index of {Array.IndexOf(numbers, numbers[chosen])}");
            Console.ReadKey();



        }
    }
}
