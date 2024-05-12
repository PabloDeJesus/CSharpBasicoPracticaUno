//Leer un número entero de cinco dígitos y determinar si es un número capicúo. (que se lea igual de izq a derecha)


        Console.WriteLine("Ingrese un número entero de cinco dígitos:");
        int numero = int.Parse(Console.ReadLine());

        
        if (numero >= 10000 && numero <= 99999)
        {
            
            int digito1 = numero / 10000;
            int digito2 = (numero / 1000) % 10;
            int digito4 = (numero / 10) % 10;
            int digito5 = numero % 10;

            if (digito1 == digito5 && digito2 == digito4)
            {
                Console.WriteLine("El número es capicúa.");
            }
            else
            {
                Console.WriteLine("El número no es capicúa.");
            }
        }
        else
        {
            Console.WriteLine("El número ingresado no tiene cinco dígitos.");
        }
    }
}