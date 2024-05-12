using System;

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

                int PrimerDigito = number / 10;
                int SegundoDigito = number % 10;

                if (PrimerDigito != 0 && SegundoDigito != 0) // Asegurarse de que ninguno de los dígitos sea cero
                {
                    if (PrimerDigito % SegundoDigito == 0 || SegundoDigito % PrimerDigito == 0)
                    {
                        Console.WriteLine("Uno de los dígitos es múltiplo del otro.");
                    }
                    else
                    {
                        Console.WriteLine("Ninguno de los dígitos es múltiplo del otro.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número entero de dos dígitos que no contenga ceros.");
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