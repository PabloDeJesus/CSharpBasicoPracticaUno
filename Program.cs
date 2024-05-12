﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero de dos dígitos:");
        string input = Console.ReadLine();

        try
        {
            if (input.Length == 2)
            {
                int number = Convert.ToInt32(input);

                int firstDigit = number / 10;
                int secondDigit = number % 10;

                if (firstDigit == secondDigit)
                {
                    Console.WriteLine("Los dos dígitos son iguales.");
                }
                else
                {
                    Console.WriteLine("Los dos dígitos no son iguales.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero de dos dígitos.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
        }

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}