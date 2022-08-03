class Program
{
    /*
    Teniendo en cuenta que la clave es “eureka”, escribir un programa que nos pida ingresar
    una clave. Sólo se cuenta con 3 intentos para acertar, si fallamos los 3 intentos se deberá
    mostrar un mensaje indicándonos que hemos agotado esos 3 intentos. Si acertamos la
    clave se deberá mostrar un mensaje que indique que se ha ingresado al sistema
    correctamente.
    */
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese una clave");
        string clave = Console.ReadLine();
        int i = 0;
        if (clave == "eureka")
        {
            Console.WriteLine("Ha ingresado al sistema correctamente");
        }
        else
        {
            while(i < 3)
            {
                Console.WriteLine("Ingrese nuevamente la clave");
                clave = Console.ReadLine();
                if  (clave == "eureka")
                {
                    Console.WriteLine("Ha ingresado al sistema correctamente");
                    break;
                }
                i++;
            }
        }
    }
}