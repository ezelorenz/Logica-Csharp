class Program
{
    /*
    Realizar un programa que pida tres notas y determine si un alumno aprueba o reprueba un
    curso, sabiendo que aprobará el curso si su promedio de tres calificaciones es mayor o
    igual a 70; y reprueba en caso contrario.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese tres notas");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double nota3 = double.Parse(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;
        
        if (promedio > 70)
        {
            Console.WriteLine("Aprueba");
        } else
        {
            Console.WriteLine("Reprueba");
        }


    }
}