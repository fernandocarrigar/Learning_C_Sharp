using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AsyncTask<T>
{
	public static void MaetodoList()
	{
		var list = new List<T>();
	}
	public static async Task<int> TareasAsincronas(T arry)
	{
		int num1 = 123;
		int num2 = 324;

		var tarea = new Task<int>(() => new Random().Next(100));
		//Tarea2<T> = tarea;
		Console.WriteLine(tarea);
		tarea.Start();

		await tarea;
		Console.WriteLine("Esta es la resta {0}", num1 - num2);

		return await tarea;
	}

	//public static void Main()
	//{
	//	TareasAsincronas();
	//}

}
