using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int K = 5;
        string[] sequence = { "Hello", "World", "CSharp", "is", "Awesome", "!", "12345" };

        
        var extractedStrings = sequence.Take(K).Where(s => s.Length % 2 != 0 && char.IsUpper(s[0])).Reverse();

        
        Console.WriteLine("Извлеченные строки: " + string.Join(", ", extractedStrings));
    }
}