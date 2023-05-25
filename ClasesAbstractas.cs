using System;

abstract class PHerenClase          //abstract en una clase limita la instancia de la clase para crear objetos, lo cual evita que se utilicen sus propiedades fuera de ella
{
    public string phfields = "Este campo pertenece a la clase pherenclase";
    public int phfieldi = 1;
    private string cphfieldpriv;
    public string cphfieldpub;

    public string Cphfieldpriv2 { get { return cphfieldpriv; } set { cphfieldpriv = value; } }

    public virtual string PMet()
    {
        return "Virtual permite que el metodo se modifique aunque sea de una clase base";
    }

    public virtual string PMet1()
    {
        return "Sin virtual es imposible modificar un metodo de clase base";
    }

    public PHerenClase()
    {
        cphfieldpriv = "Esta variable pertenece a la clase PHerenClase y esta en un constructor es privada";
        cphfieldpub = "Esta variable pertenece a la clase PHerenClase y esta en un constructor es publica";
    }

    public abstract string HSumMet(int num1, int num2);         //abstract te permite limitar el uso del metodo unicamente dentro de una clase denominada abstract de igual forma. Los metodos abstract son vacios de codigo

}

class HHerenClase : PHerenClase         //Con los : Te permite heredar propiedades de una clase a otra, de tal manera que puedan ser usados sin distincion y de esta forma es posible usar clases y metodos abstract
{
    public int hhfieldi = 2;

    public override string HSumMet(int num1, int num2)      //Override sirve para reemplazar o modificar un metodo heredado y de esta manera cambiar su uso, no importa los permisos que tenga, lo sobreescribe
    {
        int total = num1 + num2;
        return $"El total de la suma es: {total}";
    }

    public override string PMet()
    {
        return "Ya con virtual se puede modificar el metodo";
    }

    public override string PMet1()         //al agregarsele parametros de entrada a un metodo, se genera una sobrecarga lo cual permite usar un nombre de metodo de diferentes maneras y ahora existen 2 metodos llamados iguales
    {
        return "Sin virtual en el metodo de clase base, es imposible modificar";
    }


}


//class Result
//{
//    public static void Main(string[] args)
//    {
//        var myObj = new HHerenClase();                                  //Se instancia un objeto mediante una clase la cual tienen propiedades heredadas
//        object res = myObj.HSumMet(myObj.phfieldi, myObj.hhfieldi);     //Se utiliza un metodo con le objeto y se guarda el resultado en una variable de tipo objeto la cual permite cualquier tipo de dato

//        Console.WriteLine(res);
//        Console.WriteLine(myObj.Cphfieldpriv2);                         //Se esta llamando a una propiedad para acceder a los datos de un campo privado dentro de una clase el cual hereda sus propiedades
//        Console.WriteLine(myObj.cphfieldpub);
//        Console.WriteLine(myObj.PMet());
//        Console.WriteLine(myObj.PMet1());
//        Console.WriteLine(myObj.phfields);
//        //Console.ReadLine();
//    }
//}
