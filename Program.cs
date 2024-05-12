//Leer un número entero de tres dígitos y determinar si algún dígito es múltiplo de los otros.
    



Console.WriteLine("Ingrese un número entero de tres dígitos:");
int numero = int.Parse(Console.ReadLine());


if (numero >= 100 && numero <= 999)
{
    int digito1 = numero / 100;  
    int digito2 = (numero / 10) % 10;  
    int digito3 = numero % 10;  

     
    if (digito1 % digito2 == 0 || digito1 % digito3 == 0 ||
        digito2 % digito1 == 0 || digito2 % digito3 == 0 ||
        digito3 % digito1 == 0 || digito3 % digito2 == 0)
    {
        Console.WriteLine("Al menos un dígito es múltiplo de otro.");
    }
    else
    {
        Console.WriteLine("Ningún dígito es múltiplo de otro.");
    }
}
else
{
    Console.WriteLine("El número ingresado no tiene tres dígitos.");
}
    
