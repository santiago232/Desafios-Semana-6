using System;

class NumerosPares
{
    static void Main(string[] args)
    {
        Console.Write("Por favor, ingresa un número entero positivo: ");

        int numero;

        if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
        {
            Console.WriteLine("Error: Debes ingresar un número entero positivo.");
            return;
        }

        Console.WriteLine("Los números pares desde 1 hasta " + numero + " son:");

        int contador = 1;

        while (contador <= numero)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine(contador);
            }

            contador++;
        }
    }
}
