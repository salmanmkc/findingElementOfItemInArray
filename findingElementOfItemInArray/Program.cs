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
            int[] numbers = createRandomArray(rnd, j);

            Console.WriteLine("Your radomly generated array: ");
            printArray(numbers);
            int chosen = printChosenValueAndIndex(rnd, j, numbers);

            //doing this to just make it seem like it takes time to find the number
            fakeLoading();
            Console.WriteLine();
            findIndex(numbers, chosen);
            Console.ReadKey();



        }

        private static void findIndex(int[] numbers, int chosen)
        {
            Console.WriteLine($"{numbers[chosen]} has index of {Array.IndexOf(numbers, numbers[chosen])}");
        }

        private static void fakeLoading()
        {
            string finding = "finding...";
            foreach (var c in finding)
            {
                Console.Write(c);
                Thread.Sleep(200);
            }
        }

        private static int printChosenValueAndIndex(Random rnd, int j, int[] numbers)
        {
            int chosen = rnd.Next(0, j - 1);
            Console.WriteLine($"{chosen} index has value {numbers[chosen]}");
            return chosen;
        }

        private static void printArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static int[] createRandomArray(Random rnd, int j)
        {
            int[] numbers = new int[j];
            for (int i = 0; i < j; i++)
            {
                //need to make sure there are no number repeats
                int randomly = rnd.Next(1, 11);
                while (numbers.Contains(randomly))
                {
                    randomly = rnd.Next(1, 11);

                }
                numbers[i] = randomly;
            }

            return numbers;
        }
    }
}
