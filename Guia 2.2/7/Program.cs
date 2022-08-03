class Program
{
    /*
        Realizar un programa que pida una frase y el programa deberá mostrar la frase con un
    espacio entre cada letra. La frase se mostrará así: H o l a. Nota: recordar el funcionamiento
    de la función Subcadena().
    NOTA:. En PseInt, si queremos escribir sin que haya saltos de línea, al final de la operación
    “escribir” escribimos “sin saltar”. Por ejemplo:
    Escribir sin saltar “Hola, “
    Escribir sin saltar “cómo estás?”
    Imprimirá por pantalla: Hola, cómo estás?
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Escribir una frase");
        string frase = Console.ReadLine();
        int i;
        for (i = 0; i< frase.Length; i++)
        {
            Console.Write(frase[i] + " ");
        }
    }
}