class Program
{
    /*
    Realizar un programa que pida 3 notas y valide si esas notas estan entre 1 y 10.
    Si estran entre esos parametros se debe poner en verdadero una variable de tipo logico y
    si no ponerla en falso.
    Al final el programa debe decir si las 3 notas son correctas usando la variable de tipo logico.
    */
    static void Main(string[] args)
    {
        int nota1;
        int nota2;
        int nota3;

        bool estado1;
        bool estado2;
        bool estado3;
        bool resultado;

        Console.WriteLine("Ingrese 3 notas");
        nota1 = Convert.ToInt32(Console.ReadLine());

        if (nota1 > 0 && nota1 <= 10)
        {
            estado1 = true;
        }else
        {
            estado1 = false;
        }

        Console.WriteLine();
        nota2 = Convert.ToInt32(Console.ReadLine());

        if (nota2 > 0 && nota2 <= 10)
        {
            estado2 = true;
        }
        else
        {
            estado2 = false;
        }
        Console.WriteLine();
        nota3 = Convert.ToInt32(Console.ReadLine());
        if (nota3 > 0 && nota3 <= 10)
        {
            estado3 = true;
        }
        else
        {
            estado3 = false;
        }

        resultado = estado1 & estado2 & estado3;
        
        Console.WriteLine(resultado);
    }
}