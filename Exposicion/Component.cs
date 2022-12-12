using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public abstract class COMPONENT
    {   
        //Creamos nuestra clase padre de manera abstracta para que se puedan sobreescribir los metodos en las clases hijas (en caso que se necesitara)
        public string Objeto { get; set; }
        public int Cantidad { get; set; }
        //Se hace un constructor para guardar las propiedades
        public COMPONENT(string Objeto, int Cantidad)
        {
            this.Objeto = Objeto;
            this.Cantidad = Cantidad;
        }
    }
}