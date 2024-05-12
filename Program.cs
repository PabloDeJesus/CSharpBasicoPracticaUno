//Leer un número entero de tres dígitos y determinar si el primer dígito es igual al ultimo

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero de tres dígitos:");
        int numero = int.Parse(Console.ReadLine());

         
        if (numero >= 100 && numero <= 999)
        {
            int primerDigito = numero / 100;  
            int tercerDigito = numero % 10;  

             
            if (primerDigito == tercerDigito)
            {
                Console.WriteLine("El primer dígito es igual al último.");
            }
            else
            {
                Console.WriteLine("El primer dígito no es igual al último.");
            }
        }
        else
        {
            Console.WriteLine("El número ingresado no tiene tres dígitos.");
        }
    }
}