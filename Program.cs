    //class NewProgram
    //{
    //    static void Main()
    //    {

            //string txt = "This method works for";
            //string txt1 = "print a unique line the text what they have";
            //string txt2 = "print in the line without care if the same line of the other method";

            //Console.WriteLine(txt + " " + txt1);    //Concatenation of  two variables strings
            //Console.Write(txt + " " + txt2);        //Concatenation of  two variables strings
            //Console.WriteLine("");
            //Console.WriteLine("El largo del primer texto es: " + (txt + txt1).Length);
            //Console.WriteLine("El largo del segundo texto es: " + (txt + txt2).Length);

            ////Change data type
            //int time = 124578;      //This first data is int type
            //double nTime = time;    //This is an automatic convertion of int to double
            //int rTime = (int)nTime; //This is a manual convertion to the double to int

            //Console.WriteLine(time + " " + nTime + " " + rTime);        //Se pueden concatenar diferentes variables

            ////Read code
            //string insName = "Please enter your name:";
            //Console.WriteLine(insName);

            //string valName = Console.ReadLine();       //Permite recibir datos de tipo string por medio de consola

            //string prtText = $"Your names is: {valName} That is correct?";      //Se pueden concatenar variables dentro de una cadena de texto poniendo un signo de dolar al inicio de la cadena y la variable entre llaves

            //Console.WriteLine(prtText);

            //string text3 = Console.ReadLine();
            //string textUp = text3.ToUpper();

            //int i = 1;
            //while (i == 1)       //Ciclo while mientras se cumpla la condicion, seguira ejecutandoe
            //{

            //    switch (textUp)         //Variante de if else para toma de decisiones mediante condiciones
            //    {
            //        case "SI":          //case es una condicion a evaluar, si se cumple se ejecuta el codigo debajo hasta encontrar un break
            //            Console.WriteLine("Correcto");
            //            i--;
            //            break;          //break detiene los procesos de este bloque de codigos y termina con la ejecucion del switch
            //        case "YES":
            //            Console.WriteLine("Correcto en ingles");
            //            i--;
            //            break;
            //        case "NO":
            //            Console.WriteLine("¿Entonces cual es?");
            //            string newValName = Console.ReadLine();
            //            textUp = "SI";
            //            break;
            //        default:
            //            Console.WriteLine("Solo Respuestas de SI o NO");
            //            i = 1;
            //            string newAns = Console.ReadLine();
            //            textUp = newAns.ToUpper();
            //            break;
            //    }
            //}

            //Console.WriteLine("Please enter a number:");

            //string num1 = Console.ReadLine();

            //int numCov = Convert.ToInt32(num1);     //Convierte de manera forzada un dato a otro tipo, existen variantes de Convert.To

            //Console.WriteLine("No inserto numero");

            //Console.WriteLine(string.Concat("Your number is: ", num1));

            //int lgtName = valName.Length;       //Devuelve la longitud de una cadena de texto tipo String

            //Console.WriteLine(valName.ToUpper());       //Devuelve la cadena String convertido a mayusculas
            //Console.WriteLine(valName.ToLower());       //Devuelve la cadena String convertido a minusculas

            //Console.WriteLine("Tu nombre tiene un largo de : " + lgtName);
            //Console.WriteLine(lgtName > numCov ? "Tu nombre es mas largo que el numero insertado"       //Es la version de un If... Else recortado
            //    : lgtName < numCov ? "El numero insertado es mayor al largo de tu nombre"               //Es la version de un If... Else recortado
            //    : "EL tamaño es igual");                                                                //Es la version de un If... Else recortado

            //int indName = valName.IndexOf("e");     //Devuelve el numero de indice del primer dato encontrado igual al asignado
            //string newChain = valName.Substring(indName);       //Devuelve la cadena a partir del numero indice que se le indica, generando una nueva cadena

            //Console.WriteLine($"Tu diminutivo puede ser \"{newChain}\"");       // La barra invertida \ te permite ejecutar comillas simples, dobles y barra invertida dentro de una cadena

            //int num3 = Math.Max(1980, 138);     //Devuelve el numero mayor

            //int num2 = Math.Min(167, 19324);    //Devuelve el numero menor

            //double num4 = Math.Sqrt(Math.Abs(num3 - num2));        //ABS convierte en positivo el numero negativo y Sqrt devuelve la raiz cuadrada

            //Console.WriteLine(Math.Round(num4));        //Redondea un numero decimal a un entero cercano.


    //    }
    //}
//}
