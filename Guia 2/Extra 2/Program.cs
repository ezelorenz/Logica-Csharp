class Program
{
    /*
    Una tienda ofrece para los meses de septiembre, octubre y noviembre un descuento del
    10% sobre el total de la compra que realiza un cliente. Solicitar al usuario que ingrese un
    mes y el importe de la compra. El programa debe calcular cuál es el monto total que se
    debe cobrar al cliente e imprimirlo por pantalla.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese el mes de la compra");
        Console.WriteLine("1 - ENERO, 2 - FEBRERO, 3 - MARZO, 4 - ABRIL, 5 - MAYO, 6 - JUNIO");
        Console.WriteLine("7 - JULIO, 8 - AGOSTO, 9 - SEPTIEMBRE, 10 - OCTUBRE, 11 - NOVIEMBRE, 12 - DICIEMBRE");

        int mes = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el monto de la compra");

        double precio = double.Parse(Console.ReadLine());
        double precioDescuento = precio * 0.9;
        if (mes == 9 || mes == 10 || mes == 11)
        {
            Console.WriteLine($"Mes de descuento su saldo es de: {precioDescuento}");
        }else
        {
            Console.WriteLine($"Mes sin descuento, su saldo es {precio}");
        }
        
        
    }
}