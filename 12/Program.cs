using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Input the string: ");
        string inputString = Console.ReadLine();

        
        string[] words = inputString.Split(' ');

        
        var upperCaseWords = words.Where(word => word == word.ToUpper());

        
        Console.WriteLine("The UPPER CASE words are:");
        foreach (string word in upperCaseWords)
        {
            Console.WriteLine(word);
        }

       
    }
}