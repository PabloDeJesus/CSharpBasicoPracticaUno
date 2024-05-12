//Leer Un numero entero y determinar si es negativo

<using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

       
        Console.WriteLine("\t\tSaber si el numero es Positivo, Negativo, o 0.");

       
        Console.Write("\n\tIngrese un Numero: ");

        
        num = Int32.Parse(Console.ReadLine());

     
        if (num == 0)
        {
            Console.Write("\n\tSu Numero es 0.");
        }
        else if (num >= 1)
        {
            Console.Write("\n\tSu numero '" + num + "' es Positivo.");
        }
        else if (num <= -1)
        {
            Console.Write("\n\t'tSu numero '" + num + "' es Negativo.");
        }

      
        Console.Write("\n\n\tPresione < ENTER > para continuar . . .");
        Console.ReadKey();
    }
}
>