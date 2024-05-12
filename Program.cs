//Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina número par

    {
        Console.WriteLine("Ingrese el primer número entero de dos dígitos:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo número entero de dos dígitos:");
        string input2 = Console.ReadLine();

        try
        {
            if (input1.Length == 2 && input2.Length == 2)
            {
                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);

                int suma = number1 + number2;

                if (suma % 2 == 0)
                {
                    Console.WriteLine("La suma de los dos números origina un número par.");
                }
                else
                {
                    Console.WriteLine("La suma de los dos números no origina un número par.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese dos números enteros de dos dígitos.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese dos números enteros válidos.");
        }

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}
