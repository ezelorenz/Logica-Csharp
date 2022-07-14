class Program
{
    /*
    Realizar un programa que simule un menu de opciones para realizar
    las cuatro operaciones aritmeicas basicas (suma, resta, multiplicacion, division)
    con dos valores numericos enteros.
    El usuario debe especificar la operacion con el primer caracter de la operacion
    'S' o 's' para la suma, 'R' o 'r' para la resta,'M' o 'm' para la multiplicacion y 'D' o 'd'
    para la division.
    */
    static void Main(string[] args)
    {
        string opcion;
        Console.WriteLine("Ingrase el tipo de operacion que desea realizar: ");
        Console.WriteLine("'S' o 's' para la suma, 'R' o 'r' para la resta, 'M' o 'm' para la multiplicacion y 'D' o 'd' para la division.");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            
            case "S" or "s": 
                Console.WriteLine("Ingrese los numeros que quiere sumar");
                int num1 = Int32.Parse(Console.ReadLine());
                int num2 = Int32.Parse(Console.ReadLine());
                int sumatoria = num1 + num2;
                Console.WriteLine("El resultado es: " + sumatoria);
                break;

            case "R" or "r":
                Console.WriteLine("Ingrese los numeros que quiere restar");
                int num3 = Int32.Parse(Console.ReadLine());
                int num4 = Int32.Parse(Console.ReadLine());
                int resta = num3 - num4;
                Console.WriteLine("El resultado es: " + resta);
                break;

            case "M" or "m":
                Console.WriteLine("Ingrese los numeros que quiere sumar");
                int num5 = Int32.Parse(Console.ReadLine());
                int num6 = Int32.Parse(Console.ReadLine());
                int multi = num5 * num6;
                Console.WriteLine("El resultado es: " + multi);
                break;

            case "D" or "d":
                Console.WriteLine("Ingrese los numeros que quiere sumar");
                int num7 = Int32.Parse(Console.ReadLine());
                int num8 = Int32.Parse(Console.ReadLine());
                int div = num7 / num8;
                Console.WriteLine("El resultado es: " + div);
                break;

            default: Console.WriteLine("Operacion incorrecta"); break;
        }
    }
}