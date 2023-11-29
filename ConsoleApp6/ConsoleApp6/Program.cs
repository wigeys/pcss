using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int D = 5;
        int K = 3;
        int[] sequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        var firstFragment = sequence.TakeWhile(n => n <= D);

        
        var secondFragment = sequence.Skip(K - 1);

        
        var union = firstFragment.Concat(secondFragment).Distinct();

        
        var sortedUnion = union.OrderByDescending(n => n);

        
        Console.WriteLine("Отсортированная последовательность: " + string.Join(", ", sortedUnion));
    }
}