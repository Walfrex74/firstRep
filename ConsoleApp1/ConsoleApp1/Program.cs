using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] ints = new int[10];
            int len = ints.Length;

            Console.WriteLine($"Максимальное число: " + max(3, 4, 5, 0));
            Console.WriteLine($"Катангенс: " + ctg(2));

            Console.ReadKey();
        }

        static int max(int one, int two, int three, int result)
        {
            result = Math.Max(one, two);
            result = Math.Max(result, three);

            return result;
        }

        static double ctg(int one)
        {
            return Math.Cos(one) / Math.Sin(one);
        }
    }
}