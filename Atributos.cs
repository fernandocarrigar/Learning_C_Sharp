using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atributes
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)] 
    public class Nombres : Attribute
    {
        private readonly string _name;

        public Nombres(string nombre)
        {
            _name = nombre;
        }

        public string GetName()
        {
            return _name;
        }
    }

    //[_name("")]
    public class Atrapa
    {
       
    }
}
