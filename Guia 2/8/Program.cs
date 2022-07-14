class Program
{
    /*
    Realizar un programa que pida una frase o palabra, y valide si la primer letra de esa frase
    es igual a la ultima. De ser asi debera imprimir un mensaje que diga "CORRECTO".
    En caso contrario "INCORRECTO"
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una frase o palabra");
        string palabra = Console.ReadLine();
        string ultima = palabra.Substring(palabra.Length - 1);

        

        if (palabra.Substring(0, 1) == ultima)
        {
            Console.WriteLine("CORRECTO");
        }
        else
        {
            Console.WriteLine("INCORRECTO");
        }
    }
}