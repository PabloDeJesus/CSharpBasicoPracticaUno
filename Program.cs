

//Leer un número entero de tres dígitos y determinar a cuánto es igual la suma de sus dígitos.

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

                int sum = PrimerDigito + SegundoDigito + TercerDigito;

                Console.WriteLine("La suma de los dígitos es: " + sum);
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