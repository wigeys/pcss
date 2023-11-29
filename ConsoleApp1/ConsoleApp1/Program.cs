﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int[] sequence = { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

        
        int firstPositive = sequence.FirstOrDefault(n => n > 0);

        
        int lastNegative = sequence.LastOrDefault(n => n < 0);

        
        Console.WriteLine("Первый положительный элемент: " + firstPositive);
        Console.WriteLine("Последний отрицательный элемент: " + lastNegative);
    }
}