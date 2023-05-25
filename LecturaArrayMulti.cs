using System;

class LecArray {
    public static int[,] multiArr = { { 1, 2, 3, 4 }, { 2, 3, 4, 6 } };     //De esta manera se declara un array multidimensional, casi siempre se tienen que definir sus datos de inicio


    ////public static void Main()
    ////{

    ////    for (int i = 0; i < multiArr.GetLength(0); i++)     //GetLength funciona para devolvernos el largo de un Array multidimensional de acuerdo al indice que se le indique
    ////    {

    ////        for (int j = 0; j < multiArr.GetLength(1); j++)
    ////        {
    ////            Console.WriteLine(multiArr[i, j]);
    ////        }
    ////    }

    ////    Console.WriteLine(multiArr.GetLength(1));

    ////    Console.WriteLine(multiArr);


    ////    int[,] newArr = new int[3, 4];
    ////    newArr[0, 0] = 10;
    ////    newArr[0, 1] = 20;
    ////    newArr[0, 2] = 30;
    ////    newArr[0, 3] = 50;
    ////    newArr[1, 0] = 60;
    ////    newArr[1, 1] = 100;
    ////    newArr[1, 2] = 1000;
    ////    newArr[1, 3] = 1000;
    ////    newArr[2, 0] = 1000;
    ////    newArr[2, 1] = 1000;
    ////    newArr[2, 2] = 1000;
    ////    newArr[2, 3] = 112;

    ////    int[] simArr = { 2, 3, 5, 6, 8, 9 };

    ////    for (int i = 0; i < newArr.GetLength(0); i++)
    ////    {
    ////        for (int j = 0; j < newArr.GetLength(1); j++)
    ////        {
    ////            Console.WriteLine(newArr[i, j]);
    ////        }
    ////    }

    ////    Console.WriteLine(simArr);
    ////    Console.WriteLine(newArr);
    ////}
}