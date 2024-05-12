
// Leer dos números enteros y determinar cuál es el mayor.


    {
        Console.WriteLine("Ingrese el primer número entero:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo número entero:");
        string input2 = Console.ReadLine();

        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            if (number1 > number2)
            {
                Console.WriteLine("El primer número ({0}) es mayor que el segundo número ({1}).", number1, number2);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("El segundo número ({0}) es mayor que el primer número ({1}).", number2, number1);
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese dos números enteros válidos.");
        }

        Console.ReadLine(); 
    }
}
