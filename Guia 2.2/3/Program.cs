class Program
{
    /*
    Dada una secuencia de números ingresados por teclado que finaliza con un –1, por
    ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,......,-1; realizar un programa que calcule el promedio de los
    números ingresados. Suponemos que el usuario no insertará número negativos.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese un numero para");
        int suma, num, i,ingresos;
        double promedio;
        num = Int32.Parse(Console.ReadLine());
        suma = 0;
        i = 1;
        while (num != -1)
        {
            
            suma = suma + num;
            i = i + 1;
            
            Console.WriteLine("Ingrese numero");
            num = Int32.Parse(Console.ReadLine());
        }
        ingresos = i -1;
        promedio = suma / ingresos;
        Console.WriteLine($"Ha ingresado {ingresos} numeros. El promedio es: {promedio}");
    }
}