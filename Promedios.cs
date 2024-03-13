using System;

class CalculadorPromedioEstudiante
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al Calculador de Promedio de Estudiantes.");

        double sumaPuntajes = 0; 
        int cantidadPuntajes = 0; 

        while (true)
        {
            Console.Write("Ingrese el puntaje del estudiante (entre 1 y 10) o escriba 'fin' para terminar: ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
            {
                if (cantidadPuntajes == 0)
                {
                    Console.WriteLine("No se han ingresado puntajes.");
                }
                else
                {
                    double promedio = sumaPuntajes / cantidadPuntajes;
                    Console.WriteLine($"El puntaje promedio del estudiante es: {promedio:F2}");
                }
                break;
            }

            if (double.TryParse(entrada, out double puntaje) && puntaje >= 1 && puntaje <= 10)
            {
                sumaPuntajes += puntaje;
                cantidadPuntajes++;
            }
            else
            {
                Console.WriteLine("Error: Por favor, ingrese un puntaje válido (entre 1 y 10) o 'fin' para terminar.");
            }
        }
    }
}
