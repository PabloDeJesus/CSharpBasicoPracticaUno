
//Leer un número entero de tres dígitos y determinar en qué posición está el mayor dígito


    {
        Console.WriteLine("Ingrese un número entero de tres dígitos:");
        string input = Console.ReadLine();

        try
        {
            if (input.Length == 3)
            {
                int number = Convert.ToInt32(input);

                int PrimerDigito = number / 100;  
                int SegundoDigito = (number / 10) % 10; 
                int TercerDigito = number % 10; 

                if (PrimerDigito >= SegundoDigito && PrimerDigito >= TercerDigito)
                {
                    Console.WriteLine("El mayor dígito ({0}) está en la primera posición.", PrimerDigito);
                }
                else if (SegundoDigito >= PrimerDigito && SegundoDigito >= TercerDigito)
                {
                    Console.WriteLine("El mayor dígito ({0}) está en la segunda posición.", SegundoDigito);
                }
                else
                {
                    Console.WriteLine("El mayor dígito ({0}) está en la tercera posición.", TercerDigito);
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero de tres dígitos.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
        }

        Console.ReadLine();  
    }
}
