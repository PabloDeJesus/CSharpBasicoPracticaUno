
//Leer un número entero de cuatro dígitos y determinar a cuanto es igual la suma de sus dígitos.

    
        Console.WriteLine("Ingrese un número entero de cuatro dígitos:");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1000 && numero <= 9999)
        {
     
            int digito1 = numero / 1000;
            int digito2 = (numero / 100) % 10;
            int digito3 = (numero / 10) % 10;
            int digito4 = numero % 10;

            int suma = digito1 + digito2 + digito3 + digito4;

            Console.WriteLine($"La suma de los dígitos es: {suma}");
        }
        else
        {
            Console.WriteLine("El número ingresado no tiene cuatro dígitos.");
