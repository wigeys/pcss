using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int K = 2;
        string[] sequence = { "ABC", "DEF", "123", "GHI", "JKL", "MNO", "PQR", "STU", "VWX", "YZ0" };

        
        var firstFragment = sequence.Take(3 * K);

        
        var secondFragment = sequence.SkipWhile(s => !char.IsDigit(s[s.Length - 1]));

        
        var intersection = firstFragment.Intersect(secondFragment).Distinct();

        
        var sortedIntersection = intersection.OrderBy(s => s.Length).ThenBy(s => s);

        
        Console.WriteLine("Отсортированная последовательность: " + string.Join(", ", sortedIntersection));
    }
}