class Program
{
    /*
    Relaizar un programa que dado un numero entero, visualice en patalla si es par
    o impar. Si el valor es 0, se debe mostrar "el numero no es par ni impar"
    */
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese un numero");
        int numero = Int32.Parse(Console.ReadLine());
        if (numero == 0)
        {
            Console.WriteLine("El numero no es par ni impar");
        }
        else
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }

    }
}