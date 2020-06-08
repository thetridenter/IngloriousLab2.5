using System;

namespace IngloriousLab2._5_nonrandom

{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введіть розмірність масиву");
            n = int.Parse(Console.ReadLine());

            int[,] a = new int[n,n];

            Console.WriteLine("Елементи масиву:");

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введіть елемент №" + i + "," + j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }


            int p = 1;
            for (int i = n - 1; i > -1; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    p *= a[i, j];
                }
            }

            Console.WriteLine("\n Добуток бічної діагоналі = " + p);
        }
    }
}
