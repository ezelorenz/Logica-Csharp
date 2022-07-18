class Program
{
    /*
    Escriba un programa que valide si una nota está entre 0 y 10, sino está entre 0 y 10 la nota
    se pedirá de nuevo hasta que la nota sea correcta.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese una nota entre 0 y 10");
        int nota = Int32.Parse(Console.ReadLine());

        if (nota >= 0 && nota <= 10)
        {
            Console.WriteLine($"Su nota es: {nota}");
        }

        while (nota < 0 || nota > 10)
        {
            Console.WriteLine("Ingrese una nota entre 0 y 10");
            nota = Int32.Parse(Console.ReadLine());
        }
    }
}