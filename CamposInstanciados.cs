using System;

class Color
{
    private readonly string col = "rojo";            //campos globales que pueden ser usadas en cualquier metodo declarado
    private readonly string col1 = "amarillo";       //campos globales que pueden ser usadas en cualquier metodo declarado
    private readonly string col2 = "azul";           //campos globales que pueden ser usadas en cualquier metodo declarado
    public string col3;             //Un campo declarada en otra clase solo puede ser modificada por un objeto si la campo es publica
    public string col4;                    //Un campo declarado en una misma clase puede ser modificado por el objeto dentro de esa misma clase

    public string Col { get { return col; } }

    private string name = "prueba de get";      //Cuando se declara un campo private para poder modificarlo desde otra clase mediante un objeto, se debe crear una propiedad
    public string Name { get { return name; } set { name = value; } }       //una vez creada la propiedad se define con get si es lectura y con set si es escritura

    public Color()                  //Esto se llama metodo consructor, sirve para declarar de manera inicial valores para una clase a los campos que tiene como globales
    {
        col3 = "gris";
        col4 = "blanco";
    }

    public void MetColor(int num, int num1)         //Se puede declarar un metodo con parametros infinitos al igual que preestablecer un parametro de manera predeterminada
    {
        if (num == 1 && num1 == 2)
        {
            string colorfinal = $"{col} y {col1} hacen naranja";
            Console.WriteLine(colorfinal);
        }
        else if (num == 1 && num1 == 3)
        {
            string colorfinal = $"{col} y {col2} hacen morado";
            Console.WriteLine(colorfinal);
        }
        else if (num == 2 && num1 == 3)
        {
            string colorfinal = $"{col1} y {col2} hacen verde";
            Console.WriteLine(colorfinal);
        }


    }
}

//class Prueba
//{
//    static void Main()
//    {
//        var MyNewObj = new Color { col3 = "azul" };           //Se instancia un objeto usando una clase, para poder hacer uso de todo dentro de dicha clase

//        MyNewObj.MetColor(1, 3);
//        MyNewObj.MetColor(2, 3);
//        MyNewObj.MetColor(1, 2);

//        Color MyNewObj = new Color();           //Se instancia un objeto usando una clase, para poder hacer uso de todo dentro de dicha clase
//        MyNewObj.MetColor(1, 3);
//        MyNewObj.MetColor(2, 3);
//        MyNewObj.MetColor(1, 2);
//        MyNewObj.col3 = "gris";

//        Color MySecObj = new Color();
//        Console.WriteLine(MySecObj.col4);
//        MySecObj.col4 = "gris";
//        Console.WriteLine(MySecObj.col4);

//        Color NewName = new Color();
//        NewName.Name = "prueba de set funcionando";
//        Console.WriteLine(NewName.Name);
//    }
//}
