//Leer tres números enteros y determinar cuál es el mayor. Usar solamente dos variables.


    
        Console.WriteLine("Ingrese el primer número entero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número entero:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número entero:");
        int numero3 = int.Parse(Console.ReadLine());

        int maximo = numero1;  

         
        if (numero2 > maximo)
        {
            maximo = numero2;
        }

        
        if (numero3 > maximo)
        {
            maximo = numero3;
        }

        Console.WriteLine($"El número máximo es: {maximo}");
    