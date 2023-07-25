using System;

namespace InyectDependencia
{

	public class UsoMon
	{

		public static void Final()
		{
			var cant1 = 12;
			var cant2 = 31;
			var tpdiv = "MXN";
			var tpmon = new ElectroMon();
			var divi = new Divisas(tpmon);

			divi.Ejecutar(tpdiv, cant1, cant2);
		}
	}

	public interface InyecDepend
	{
		void Moneda(string tpdiv, double cant1, double cant2);
	}

	class ElectroMon : InyecDepend
	{
		public void Moneda(string tpdiv, double cant1, double cant2)
		{
			Console.WriteLine("El tipo de moneda es electronica");
		}
	}

	class FisicaMon : InyecDepend
	{
		public void Moneda(string tpdiv, double cant1, double cant2)
		{
			Console.WriteLine("El tipo de moneda es fisica");
		}
	}

	class Divisas
	{
		private InyecDepend _inyect;

		public Divisas(InyecDepend inyect)
		{
			_inyect = inyect;
		}

		public void Ejecutar(string tpdiv, double cant1, double cant2)
		{
			_inyect.Moneda(tpdiv, cant1, cant2);
		}
	}
}