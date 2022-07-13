class Program
{

    /*
    Realiza un pregrama que solo permita introducir los caracteres
    S y N. Si el usuario ingresa alguno de estos dos caracteres, se debera imprimir un
    mensaje ppor pantalla que diga "CORRECTO", en caso contrario, se debera imprimir "INCORRECTO"
    */
    static void Main(string[] args)
    {
        string letraValida = "S";
        string letraValida2 = "N";

        Console.WriteLine("Ingrese una letra, Mayuscula");
        string respuesta = Console.ReadLine();
        if (respuesta == letraValida || respuesta == letraValida2)
        {
            Console.WriteLine("CORRECTO");
        }
        else 
        { 
            Console.WriteLine("INCORRECTO");
        }


    }
}