class Program
{
    /*
    Realizar un programa que pida una frase o palabra, y valide si la primer letra de esa frase
    es una "A". De ser asi debera imprimir un mensaje que diga "CORRECTO".
    En caso contrario "INCORRECTO"
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una frase o palabra");
        string palabra = Console.ReadLine();


        if (palabra.Substring(0, 1) == "A")
        {
            Console.WriteLine("CORRECTO");
        }
        else
        {
            Console.WriteLine("INCORRECTO");
        }
    }
}