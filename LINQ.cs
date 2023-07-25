using System;
using System.Linq;

class IntroToLINQ
{
    static void Ejecutable()
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        List<object> numbers = new List<object> { 2, 3, 4, 5 , 3, 4, 5, 6, 1, 3, 5, 7, 2, 4, 6, 8};

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0} ", num);
        }

        Console.WriteLine("\nEste es el largo de la lista {0}",numbers.Count());

        Func<int, int> getPairs = (a) => a + 2;     //Las funciones lambda "=>" son funciones acortadas que permiten ejecutarse mediante la declaracion de una variable en la cual se alojan brevemente
        int result = getPairs(5);                   //Se llama a la variable que almacena la funcion y se inicializa

        Console.Write("\nResultado de funcion lambda: ");
        Console.Write(result);
    }

}