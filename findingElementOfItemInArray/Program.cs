using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            for(int i = 0; i < j; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }


        }
    }
}
