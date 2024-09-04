using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            
            Random r = new Random();
            int[] ints = new int[10];
            int sum = 0;
            int len = ints.Length;
            int col = 0;

            Console.WriteLine($"Максимальное число: " + max(3, 4, 5, 0));
            Console.WriteLine($"Катангенс: " + ctg(2));

            Console.WriteLine($"Сумма массива с рандомными числами: " + arr(ints, sum, r));
            Console.WriteLine($"Колличество элементов массива: " + arr_col(ints, col));

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

        public static int arr(int[] ints, int sum, Random r)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = r.Next(100);
                sum += ints[i];
            }
            return sum;
        }

        static int arr_col(int[] ints, int col)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                col++;
            }

            return col;
        }
    }
}