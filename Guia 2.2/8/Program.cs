class Program
{
    /*
    Un docente de Programación tiene un listado de 3 notas registradas por cada uno de sus
    N estudiantes. La nota final se compone de un trabajo práctico Integrador (35%), una
    Exposición (25%) y un Parcial (40%). El docente requiere los siguientes informes claves de
    sus estudiantes:
     Nota promedio final de los estudiantes que reprobaron el curso. Un estudiante
        reprueba el curso si tiene una nota final inferior a 6.5

     Porcentaje de alumnos que tienen una nota de integrador mayor a 7.5.

     La mayor nota obtenida en las exposiciones.

     Total de estudiantes que obtuvieron en el Parcial entre 4.0 y 7.5.

    El programa pedirá la cantidad de alumnos que tiene el docente y en cada alumno pedirá
    las 3 notas y calculará todos informes claves que requiere el docente.
    */
    static void Main(string[] args)
    {
        double notaFinal, notaIntegrador, notaExposicion, notaParcial, nota,
            notaReprobados,promedioIntegrador,notaMaxima,sumaReprobados, promedioReprobados;
        int alumnos, i,alumnosIntegrador,alumnosParcial,alumnosReprobados;

        alumnosIntegrador = 0;
        promedioIntegrador = 0;
        notaMaxima = 0;
        alumnosParcial = 0;
        alumnosReprobados = 0;
        sumaReprobados= 0;
        promedioReprobados = 0;

        Console.WriteLine("Ingrese la cantidad de alumnos que tiene");
        alumnos = Int32.Parse(Console.ReadLine());

        for(i = 0; i < alumnos; i++)
        {
            Console.WriteLine("Alumno N° " + (i+1));
            Console.WriteLine("Ingrese la nota del Trabajo Practico Integrador");
            notaIntegrador = Int32.Parse(Console.ReadLine());
            if (notaIntegrador > 7.5)
                alumnosIntegrador = alumnosIntegrador + 1;

            promedioIntegrador = alumnosIntegrador * 100 / alumnos;

            Console.WriteLine("Ingrese la nota de la Exposicion");
            notaExposicion = Int32.Parse(Console.ReadLine());
            if (notaExposicion > notaMaxima)
                notaMaxima = notaExposicion;

            Console.WriteLine("Ingrese la nota del Parcial");
            notaParcial = Int32.Parse(Console.ReadLine());
            if (notaParcial >= 4.0 & notaParcial <= 7.5)
                alumnosParcial = alumnosParcial + 1;

            notaFinal = (notaIntegrador * 0.35) + (notaExposicion * 0.25) + (notaParcial * 0.40);

            if (notaFinal < 6.5)
            {
                alumnosReprobados = alumnosReprobados + 1;
                sumaReprobados = sumaReprobados + notaFinal;
            }
            promedioReprobados = sumaReprobados / alumnosReprobados;
        }
        Console.WriteLine($"El {promedioIntegrador}% de alumnos tuvieron una nota mayor a 7.5 en el integrador");
        Console.WriteLine($"La nota mas alta obtenida en las Exposiciones es: {notaMaxima}");
        Console.WriteLine($"El total de estudiantes que obtuvieron entre 4.0 y 7.5 en el Parcial son: {alumnosParcial}");
        Console.WriteLine($"La nota promedio final de los alumnos que reprobaron el curso es de: {promedioReprobados}");
    }
}