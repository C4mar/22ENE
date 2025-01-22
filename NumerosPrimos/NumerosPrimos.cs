using System;

class Program
{
    static bool EsPrimo(int N)
    {
        if (N <= 1) return false;
        if (N == 2 || N == 3) return true;
        if (N % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(N); i += 2)
        {
            if (N % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        while (true)
        {
            Console.Write("Ingresa un número para verificar si es primo (o 'salir' para terminar): ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "salir")
            {
                Console.WriteLine("Programa terminado.");
                break; // Sale del bucle si el usuario escribe "salir"
            }

            if (int.TryParse(entrada, out int numero))
            {
                Console.WriteLine($"El número {numero} {(EsPrimo(numero) ? "es primo" : "no es primo")}.");
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }
    }
}
