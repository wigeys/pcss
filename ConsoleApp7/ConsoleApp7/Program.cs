using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int K = 5;
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        var firstFragment = sequence.Where(n => n % 2 == 0);

        
        var secondFragment = sequence.Skip(K);

        
        var difference = firstFragment.Except(secondFragment).Distinct();

        
        var reversedDifference = difference.Reverse();

        
        Console.WriteLine("Разность последовательностей: " + string.Join(", ", reversedDifference));
    }
}