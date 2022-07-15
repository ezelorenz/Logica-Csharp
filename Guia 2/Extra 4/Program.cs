class Program
{
    /*
        La empresa “Te llevo a todos lados” está destinada al alquiler de autos y tiene un sistema
    de tarifa que consiste en cobrar el alquiler por hora. Si el cliente devuelve el auto dentro
    de las 2 horas de uso el valor que corresponde pagar es de $400 pesos y la nafta va de
    regalo. Cuando el cliente regresa a la empresa pasadas las 2 horas, se ingresan la
    cantidad de litros de nafta gastados y el tiempo transcurrido en horas. Luego, se le cobra
    40 pesos por litro de nafta gastado, y la hora se fracciona en minutos, cobrando un total
    de $5,20 el minuto de uso. Realice un programa que permita registrar esa información y el
    total a pagar por el cliente.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese cuantas horas alquiló el auto");
        double alquiler = double.Parse(Console.ReadLine());
        if (alquiler <= 2)
        {
            Console.WriteLine("El saldo es de $400, nafta de regalo");
        }
        else
        {
            Console.WriteLine("Ingrese la cantidad de litros gastados");
            double consumo = double.Parse(Console.ReadLine());
            
            double precioConsumo = consumo * 40;
            double tiempoMinutos = alquiler * 60;
            double precioTiempo = tiempoMinutos * 5.2;
            double total = precioTiempo + precioConsumo;

            Console.WriteLine($"El valor del consumo de combustible fue: {precioConsumo} y el valor del tiempo de viaje es: {precioTiempo} " +
                $"Saldo total a pagar: {total}");
        }
    }
}