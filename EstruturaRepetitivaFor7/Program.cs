﻿using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    int primeiro = i;
                    int segundo = i * i;
                    int terceiro = i * i * i;

                    Console.WriteLine($"{primeiro} {segundo} {terceiro}");
                }
            }
        }
    }
}