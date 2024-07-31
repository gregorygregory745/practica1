using System;

class primos
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 1)
        {
            Console.WriteLine("No es primo");
            return;
        }

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine("No es primo");
                return;
            }
        }

        Console.WriteLine("Es primo");
    }
}

