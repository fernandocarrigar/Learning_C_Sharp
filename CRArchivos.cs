using System;
using System.Buffers.Text;
using System.IO;
using System.Text;


namespace StringPrub
{

    public class DataArchivo
    {

        private string text = "Este es el contenido del archivo";
        public string nameArc = "Archivo creado.pdf";

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }


    class CArchivo : DataArchivo
    {

        public string CreadorArchivos()
        {
            File.WriteAllText(nameArc,Text,Encoding.UTF8);
            bool valid = File.Exists(nameArc);

            if(valid == true)
            {
                return nameArc;
            }
            else
            {
                string error = "No se creo bien";
                return error;
            }

        }

    }

    //class RArchivo
    //{
    //    static void Main()
    //    {
    //        var myObj = new CArchivo();
    //        var nomArc = myObj.CreadorArchivos();

    //        if(nomArc == myObj.nameArc )
    //        {
    //            string reading = File.ReadAllText(nomArc);
    //            Console.WriteLine(reading);
    //            Console.WriteLine(nomArc);
    //        }
    //        else
    //        {
    //            Console.WriteLine(nomArc);
    //        }

    //    }
    //}

}