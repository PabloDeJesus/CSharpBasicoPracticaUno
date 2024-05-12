
//Leer dos números enteros de dos dígitos y determinar si tienen dígitos comunes.


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

                int firstDigit1 = number1 / 10;
                int secondDigit1 = number1 % 10;

                int firstDigit2 = number2 / 10;
                int secondDigit2 = number2 % 10;

                if (firstDigit1 == firstDigit2 || firstDigit1 == secondDigit2 || secondDigit1 == firstDigit2 || secondDigit1 == secondDigit2)
                {
                    Console.WriteLine("Los dos números tienen dígitos comunes.");
                }
                else
                {
                    Console.WriteLine("Los dos números no tienen dígitos comunes.");
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
