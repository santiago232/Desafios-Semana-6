using System;

class NumerosPrimos
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número entero positivo
        Console.Write("Por favor, ingresa un número entero positivo: ");

        // Variable para almacenar el número ingresado por el usuario
        int numero;

        // Leer la entrada del usuario y convertirla a un número entero
        // Verificar si la entrada es válida y positiva
        if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.WriteLine("Error: Debes ingresar un número entero positivo.");
            return;
        }
        bool esPrimo = true;

        for (int i = 2; i <= numero / 2; i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
        {
            Console.WriteLine(numero + " es un número primo.");
        }
        else
        {
            Console.WriteLine(numero + " no es un número primo.");
        }
    }
}
