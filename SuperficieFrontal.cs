using System;

class Rectangulo
{
    private readonly double alto;
    private readonly double largo;
    private readonly double superficieFrontal;

    public Rectangulo(double alto, double largo)
    {
        this.alto = alto;
        this.largo = largo;
        this.superficieFrontal = CalcularSuperficieFrontal();
    }
    public double Alto { get { return alto; } }
    public double Largo { get { return largo; } }
    public double SuperficieFrontal { get { return superficieFrontal; } }

    private double CalcularSuperficieFrontal()
    {
        return alto * largo;
    }
}

class ProgramaRectangulo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Superficie Frontal de Rectángulo");

        Console.Write("Ingrese el alto del rectángulo: ");
        double alto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el largo del rectángulo: ");
        double largo = Convert.ToDouble(Console.ReadLine());

        Rectangulo rectangulo = new Rectangulo(alto, largo);

        Console.WriteLine($"La superficie frontal del rectángulo es: {rectangulo.SuperficieFrontal}");
    }
}
;
