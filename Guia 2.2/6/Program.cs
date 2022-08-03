class Program
{
    /*
    Escribir un programa que calcule el cuadrado de los 9 primeros números naturales e
    imprima por pantalla el número seguido de su cuadrado. Ejemplo: “2 elevado al cuadrado
    es igual a 4”, y así sucesivamente.
    */
    static void Main(string[] args)
    {
        int num, i;

        for(i = 0; i < 10; i++)
        {
            Console.WriteLine(Math.Pow(i, 2));
        }

    }
}