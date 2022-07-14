class Program
{
    /*
    Escriba un programa para obtener el grado de eficiencia de un operario de una fábrica de
    tornillos, de acuerdo a las siguientes dos condiciones que se le imponen para un período
    de prueba:
    • Producir menos de 200 tornillos defectuosos.
    • Producir más de 10000 tornillos sin defectos.
    • El grado de eficiencia se determina de la siguiente manera:
    • Si no cumple ninguna de las condiciones, grado 5.
    • Si sólo cumple la primera condición, grado 6.
    • Si sólo cumple la segunda condición, grado 7.
    • Si cumple las dos condiciones, grado 8
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese cuantos tornillos defectuosos produjo");
        int tornilloConD = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cuantos tornillos sin defecto produjo");
        int tornilloSinD = Int32.Parse(Console.ReadLine());

        if ((tornilloConD > 200) & (tornilloSinD < 10000))
        {
            Console.WriteLine("Operador Grado 5");
        }
        else
        {
            if ((tornilloConD < 200) & (tornilloSinD < 10000))
            {
                Console.WriteLine("Operador Grado 6");
            }
            else
            {
                if ((tornilloConD > 200) & (tornilloSinD > 10000))
                {
                    Console.WriteLine("Operador Grado 7");
                }
                else
                {
                    if ((tornilloConD < 200) & (tornilloSinD > 10000))
                    {
                        Console.WriteLine("Operador Grado 8");
                    }
                }
            }
        }
    }
}