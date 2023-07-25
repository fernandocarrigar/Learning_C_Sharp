using System;

namespace Genericos
{
	public class ProgramaGenericos
	{
		public static void Main()
		{
			AlmacenObjetos archivos = new AlmacenObjetos(4);

			archivos.Agregar("Fernando");
            archivos.Agregar("Paulette");
            archivos.Agregar("Julissa");
            archivos.Agregar("Karla");

			String nombreP = (String)archivos.getDatosElemento(2);


        }
	}

	class AlmacenObjetos
	{
        private Object[] datosElemento;
		private int i = 0;

        public AlmacenObjetos(int z) 
		{
			datosElemento = new Object[z];
		}

		public void Agregar(Object obj)
		{
			datosElemento[i] = obj;
			i++;
		}

		public Object getDatosElemento(int i)
		{
			return datosElemento[i];
		}

	}

	class Empleado
	{
		private double _salario;

		public Empleado(double salario)
		{
			_salario = salario;


		}
	}
}
