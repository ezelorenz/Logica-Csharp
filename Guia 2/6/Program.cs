class Program
{
    /*
    Realizar un programa que pida una frase o palabra, y si la frase o palabra es de 4 caracteres de largo, 
    el programa le concatenara un signo de exclamacion al final,
    sino, uno de interrogacion al final.
    El programa mostrara despues la frase final
    */
    static void Main(string[] args)
    {
        string frase;
        int longitudFrase;
        Console.WriteLine("Ingrese una frase o palabra");
        frase = Console.ReadLine();
        longitudFrase = frase.Length;

        if (longitudFrase == 4)
        {
            Console.WriteLine(frase + "!");
        }
        else
        {
            Console.WriteLine(frase + "?");
        }
    }
}