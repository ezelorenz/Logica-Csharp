class Program
{

    /*
    Relaizar un programa que pida un numero y determine si es par o impar
    mostrar en pantalla si es par o impar.
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entero");
        int numero = Int32.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero ingraseado es par");
        }
        else
        {
            Console.WriteLine("El numero ingresado es impar");
        }
    }
}