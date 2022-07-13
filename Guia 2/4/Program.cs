class Program
{
    /*
    Relaizar un programa que pida introducir solo frases o palabras de 6 caracteres.
    Si el usuario ingresa una frase o palabra de 6 caracteres se debera imprimir un mensajes
    por pantalla que diga "CORRECTO", caso contrario "INCORRECTO".
    */
    static void Main(string[] args)
    {
        string frase;
        int longitudFrase;
        Console.WriteLine("Ingrese una frase o palabra de 6 o mas caracteres");
        frase = Console.ReadLine();
        longitudFrase = frase.Length;

        if (longitudFrase == 6)
        {
            Console.WriteLine("CORRECTO");
        }
        else
        {
            Console.WriteLine("INCORRECTO");
        }
    }
}