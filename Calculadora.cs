using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{

    public class OperacionesCalc
    {
        public double dato1;
        public double dato2;
        public string operador = "";

        public static double Suma(double num1, double num2)
        {
            num1 += num2;
            return num1;
        }

        public static double Resta(double num1, double num2)
        {
            num1 -= num2;
            return num1;
        }

        public static double Multiplicacion(double num1, double num2)
        {
            num1 *= num2;
            return num1;
        }

        public static double Division(double num1, double num2)
        {
            num1 /= num2;
            return num1;
        }

        public static double SelectOperacion(double num1, string operador, double num2)
        {
            if (operador == "*")
            {
                double resultado = Multiplicacion(num1, num2);
                return resultado;
            }
            else if (operador == "/")
            {
                double resultado = Division(num1, num2);
                return resultado;
            }
            else if (operador == "+")
            {
                double resultado = Suma(num1, num2);
                return resultado;
            }
            else if (operador == "-")
            {
                double resultado = Resta(num1, num2);
                return resultado;
            }
            else 
            {
                double resultado = num2;
                return resultado;
            }
        }

        //public static double ValOperacion(double num1, string operador, double num2)
        //{
        //    double resultado;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (operador != null && operador != "=")
        //        {
        //            resultado = SelectOperacion(num1, operador, num2);
        //            return resultado;
        //        }
        //        else if (operador != null && operador == "=")
        //        {
        //            resultado = SelectOperacion(num1, operador, num2);
        //        }
        //    }
        //}

        public double InsertOperacion(double num1, string operador, double num2)
        {
            double resultado;

            resultado = SelectOperacion(num1, operador, num2);

            return resultado;
        }
    }
    public class EjecutarCalculadora
    {
        //public static void Main()
        //{
        //    //var myObj = new OperacionesCalc();

        //    //Console.WriteLine("Inserte el primer numero:");
        //    //myObj.dato1 = Convert.ToInt64(Console.ReadLine());
        //    //Console.WriteLine("Inserte la operacion:");
        //    //myObj.operador = Console.ReadLine();
        //    //Console.WriteLine("Inserte el segundo numero:");
        //    //myObj.dato2 = Convert.ToInt64(Console.ReadLine());

        //    //var resultado = myObj.InsertOperacion(myObj.dato1, myObj.operador, myObj.dato2);
        //    //Console.WriteLine(resultado);

        //    int C = 1;
        //    C <<= 2;                //operador de desplazamiento de bites en codigo binaro...
        //    Console.WriteLine(C);
        //}
    }
}