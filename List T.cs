using System;
using System.Collections.Generic;

public class listaClase
{
	public static void Ejecute()
	{
        var fibonacciNumbers = new List<int> { 3, 1 };              //List<T> sirve para crear listas sin definir previamente el tipo de dato que se le va a ingresar, dejando a criterio que se tratara como a un objeto directamente
        
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
        
        fibonacciNumbers.Add(previous + previous2);

        foreach (var item in fibonacciNumbers)
        {
            Console.WriteLine(item);
        }
    }
}
