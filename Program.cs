﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Helloworld
{
    public static class Program
    {
        public static void Main()
        {

            Console.Write("enter first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("enter last number");
            int n2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int a = n1; a <= n2; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    if (a % b == 0)
                        sum++;

                }
                if (sum == 2)
                {
                    Console.WriteLine(a);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    continue;
                }
            }


        }
    }
}