using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insira um número:");
        int numero = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        if (numero == 0 || numero == 1)
        {
            Console.WriteLine($"{numero} pertence à sequência");
            return;
        }

        while (b <= numero)
        {
            int proximo = a + b;
            a = b;
            b = proximo;

            if (b == numero)
            {
                Console.WriteLine($"{numero} pertence à sequência");
                return;
            }
        }

        Console.WriteLine($"{numero} não pertence à sequência");
    }
}
