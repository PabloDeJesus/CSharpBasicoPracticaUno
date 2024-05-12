

//Leer un número entero de tres dígitos y determinar cuántos dígitos pares tiene.

        Console.WriteLine("Ingrese un número entero de tres dígitos:");
        int numero = int.Parse(Console.ReadLine());

        
        if (numero >= 100 && numero <= 999)
        {
            int digito1 = numero / 100; 
            int digito2 = (numero / 10) % 10;  
            int digito3 = numero % 10;  

            int contadorPares = 0;

          
            if (digito1 % 2 == 0)
            {
                contadorPares++;
            }
            if (digito2 % 2 == 0)
            {
                contadorPares++;
            }
            if (digito3 % 2 == 0)
            {
                contadorPares++;
            }

            Console.WriteLine($"El número de dígitos pares es: {contadorPares}");
        }
        else
        {
            Console.WriteLine("El número ingresado no tiene tres dígitos.");
        }
    }
}