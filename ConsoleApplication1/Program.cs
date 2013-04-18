using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 6 чисел и нажмите ENTER");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("v=");
            int v = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("z=");
            int z = int.Parse(Console.ReadLine());


            int[] array1 = new int[] { n, m, v, c, x, z };
            int summ = 0;
            for (int i = 0; i < array1.Length; i++) ;
            int mid;
            {
                summ = n + m + v + c + x + z;
            }
            mid = summ / array1.Length;
            Console.Write("Среднее арифметическое=", mid);
            Console.WriteLine();
            Console.ReadKey();



        }
    }
}
