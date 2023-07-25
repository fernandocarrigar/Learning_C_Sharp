using System;
using System.Runtime;
using System.Collections;

class Arrays
{

    public static void ArraysTp()
    {
        //string[] verbs = { "run", "walk", "eat", "fly" };     //De esta manera es mas sencillo declarar Arreglos
        //string[] adjects;                                   //Un arreglo se puede declarar y asignarsele los datos despues
        //adjects = new string[] { "ugly", "short", "tall", "cute" };      //Asignacion de datos

        //for (int i = 0; i < verbs.Length && i < adjects.Length; i++)
        //{          //Ciclo for sirve para ejecutar una cantidad determinada de veces un bloque de codigo, hasta cumplirse la condicion
        //    Console.WriteLine($"Los verbos en ingles son: {verbs[i]}");
        //    Console.WriteLine($"Los adjetivos en ingles son : {adjects[i]}");
        //};

        int[] nums = { 1, 2, 3, 4 };
        Hashtable array = new Hashtable();      //Es una clase tipo array que contiene metodos para un array de lista, lo cual permite variar el tipo de dato que se inserta, sin necesidad de especificarlo
                                                //Todos los datos insertados son tratados como tipo objeto para mejor manejo e incluso puedes insertar arrays dentro de ese mismo
                                                //Pero solo permite de 2 parametros por linea...
        array.Add(1," ");
        array.Add(2, nums);
        array.Add(3, "sfew");
        array.Add(4,"se puede?");

        ICollection k = array.Keys;             //Se tienen que definir los campos keys antes de imprimir por que sino, se pierde y no sabe xD solo en Hashtable

        foreach(object i in k)
        {
            Console.WriteLine("{0}{1}", i, array[i]);
        }

        Console.WriteLine(array);

        ArrayList array2 = new ArrayList();     //Es una clase tipo array que contiene metodos para un array de lista, lo cual permite variar el tipo de dato que se inserta, sin necesidad de especificarlo
                                                //Todos los datos insertados son tratados como tipo objeto para mejor manejo e incluso puedes insertar arrays dentro de ese mismo
        array2.Add(2);
        array2.Add(4);
        array2.AddRange(nums);
        array2.Add("texto");

        foreach (object i in array2)
        {
            Console.Write(i);
        }
        //Array.Sort(verbs);       //Array.Sort ordena alfabeticamente un arreglo al igual que numeros de menor a mayor
        //Array.Sort(nums);
        //Console.WriteLine("Cuenta: {0}", array.Count);


        //foreach (string x in verbs)         //Es como ciclo for pero hace un recorrido de un arreglo mis menos codigo
        //{
        //    Console.WriteLine(x);
        //};

        //foreach (int j in nums)
        //{
        //    Console.WriteLine(j);
        //}

        //Console.WriteLine(nums.Max());      //Retorna el numero mayor de un array de numeros
        //Console.WriteLine(nums.Min());      //Retorna el numero menor de un array de numeros
        //Console.WriteLine(nums.Sum());      //Retorna el total de la suma del array de numeros

    }

}
