using System;

public class DOWHILE
{
    public static void Ejecutar()
    {
        double val1 = 12973;
        double val2 = 0.15;
        int i = 0;

        do
        {
            Console.WriteLine("El pago total es {0:C} pero se le descontara el {1:P} de su total", val1, val2);

            val2 *= val1;
            val1 -= val2;
            Console.WriteLine("Su total es de {0:C}", val1);
            Console.WriteLine(i);
            i++;
        }
        while (i == 3);
    }
}
