﻿using System;

namespace task_DEV_1
{
    class Program
    {
        static void Main()
        {
            for (int n = 0; n <= 100; n++)
            {
                if (n % 3 == 0 && n > 0)
                {
                    Console.WriteLine("3 * " + n / 3);
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadLine();
        }
    }
}
