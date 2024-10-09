using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insira uma string:");
        string original = Console.ReadLine();

        string invertida = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }

        Console.WriteLine($"{invertida}");
    }
}
