class Program
{
    /*
    Escriba un programa en el cual se ingrese un valor límite positivo, y a continuación solicite
    números al usuario hasta que la suma de los números introducidos supere el límite inicial.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese un valor limie positivo");
        int limite = Int32.Parse(Console.ReadLine());
        int suma, num1, num2;
        suma = 0;
            while (suma < limite)
            {
                Console.WriteLine("Ingrese el numero a sumar");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero a sumar");
                num2 = Int32.Parse(Console.ReadLine());
                suma = suma + num1 + num2;
            }
    }
}