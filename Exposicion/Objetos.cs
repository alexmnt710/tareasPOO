using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class OBJETOS : COMPONENT
    {
        //Propiedades extra del objeto a guardar
        public string color { get; set; }
        public string fecha { get; set; }
        //Constructor de la clase
        public OBJETOS(string Nombre, int Cantidad, string color, string fecha)
            : base(Nombre, Cantidad)
        {
            this.color = color;
            this.fecha = fecha;
        }

    }
}