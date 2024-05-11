//Leer un numero entero y determinar si es un numero terminado en 4

Console.WriteLine("Ingrese un número entero:");
string input = Console.ReadLine();

 if (int.TryParse(input, out int number))
  {
  if (number % 10 == 4)
  {

   Console.WriteLine("El número termina en 4.");

   }

   else
   {

   Console.WriteLine("El número no termina en 4.");

   }

   }
   else
   {
   Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
   }


   Console.ReadLine(); //fin del proyecto