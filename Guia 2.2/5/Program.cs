class Program
{
    /*
    Escribir un programa que lea números enteros hasta teclear 0 (cero). Al finalizar el
    programa se debe mostrar el máximo número ingresado, el mínimo, y el promedio de
    todos ellos.
    */
    static void Main(string[] args)
    {
        
        int i, max, num, min, suma;
        suma = 0;
        num = 1;
        min = 1000;
        max = 0;
        i = 0;
        double prom;
        while (num != 0)
        {
            Console.WriteLine("Ingrese un numero, para finalizar teclee 0");
            num = Int32.Parse(Console.ReadLine());
            suma = suma + num;
            i++;
            if ((min > num) && (num != 0))
            {
                min = num;
            }
            else if (max < num)
            {
                max = num;
            }
        }
        prom = suma / (i - 1);
        Console.WriteLine($"El promedio es {prom}, el numero Maximo es {max} y el numero minimo es {min}");
    }
}