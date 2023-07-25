using System;
using System.IO;
using System.Text;

namespace Archivos
{
	public class LeeArchivos
	{
        private static readonly string path = @"C:\Users\USUARIO\Desktop\PruebaArchivo.pdf";

        public static void CrearFile()
		{

			try
			{
				if (File.Exists(path))			//File es una clase que se usa para obtener los metodos estaticos que ya contiene, a los metodos estaticos no se necesita instanciar puesto que al ser estaticos son se acceso directo
				{								//Exists() Comprueba que exista la direccion o ruta otorgada a travez de variable o forma directa
					File.Delete(path);			//Delete() Elimina cualquier dicho archivo si es encontrado en esa ruta, permitiendonos crear uno nuevo o eliminar todo rastro
				}

				using (FileStream arcFile = File.Create(path))			//FileStream es una clase que permite hacer una puerta de acceso a cualquier parte de los archivos
				{                                                       //Create() permite crear un archivoo sobre escribirlo en caso de que ya exista
					Byte[] btData = new UTF8Encoding(true).GetBytes("Contenido del documento o archivo");		//UTF8Encoding es una clase que sirve para codificar el texto y de esta manera si añaden caracteres varios, podran ser legibles
					arcFile.Write(btData, 0,btData.Length);				//Pasamos los bytes, despues a partir de cual leer y por ultimo, la longitud de lo que va a leer
				}
				string text = "";
				using (StreamReader readFile = File.OpenText(path))		//Using funciona para ejecutar un codigo y al final de este, borrar de memoria todo lo que contenia
				{														//StreamReader es una clase como File que ayuda a leer y modificar archivos
					string r = "";										//OpenText abre el archivo de acuerdo a la ruta especificada
					while ((r = readFile.ReadLine()) != null)
					{
						text += r;
					}
				}
				Console.WriteLine(text);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}		
			Console.ReadKey();
		}
	}
}