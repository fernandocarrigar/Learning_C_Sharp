using System;

namespace StringPrub
{

    class Prub
    {
        private int[,] newArr = new int[3, 4];

        public int[,] NewArr { get { return newArr; } set { newArr = value; } }

        public Prub()
        {
            _ = new int[3, 4, 5];
        }

        public void MethodRead()
        {

            for (int i = 0; i < NewArr.GetLength(0); i++)           //Esta bloque de codigo sirve para insertar datos de manera automatica en un array multidimensional
            {
                Console.Write("{");

                for (int j = 0; j < NewArr.GetLength(1); j++)
                {

                    Console.Write($"{{{NewArr[i, j]}}}");

                }

                Console.WriteLine("}");
            }
        }

    }

    class Ciclo : Prub
    {
        public virtual int[,] MethodFor(int[,] arr1)
        {
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = i + j;

                }
            }

            return arr1;

        }
    }

    //    class Final
    //    {
    //        static void Main()
    //        {
    //            var myObj = new Ciclo();
    //            myObj.MethodFor(myObj.NewArr);
    //            myObj.MethodRead();
    //        }
    //    }
}