using System;

class Program
{
    static void Main(string[] args)
    {

        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double Outros = 19849.53;
        double Total = SP + RJ + MG + ES + Outros;

        double PCSP = (SP / Total) * 100;
        double PCRJ = (RJ / Total) * 100;
        double PCMG = (MG / Total) * 100;
        double PCES = (ES / Total) * 100;
        double PCOutros = (Outros / Total) * 100;

        Console.WriteLine($"{PCSP}% do total");
        Console.WriteLine($"{PCRJ}% do total");
        Console.WriteLine($"{PCMG}% do total");
        Console.WriteLine($"{PCES}% do total");
        Console.WriteLine($"{PCOutros}% do total");

     } 
}
