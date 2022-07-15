class Program
{
    /*
    Solicitar al usuario que ingrese dos números enteros y determinar si ambos son pares o
    impares. Mostrar en pantalla un mensaje que indique “Ambos números son pares” siempre
    y cuando cumplan con la condición. En caso contrario se deberá imprimir el siguiente
    mensaje “Los números no son pares, o uno de ellos no es par”.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese dos numeros enteros");
        int num1 = Int32.Parse(Console.ReadLine());
        
        int num2 = Int32.Parse(Console.ReadLine());

        if ((num1 % 2 == 0) && (num2 % 2 == 0))
        {
            Console.WriteLine("Ambos numeros son pares");
        }else
        {
            Console.WriteLine("Los números no son pares, o uno de ellos no es par");
        }
    }
}