using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class CajaCOMPOSITE : COMPONENT

    {

        //Se crea una lista para poder hacer el recuento de cuantos objetos hay guardado
        private List<COMPONENT> Objetos = new List<COMPONENT>();

        public decimal ValorTotal
        {
            get
            {
                decimal Valor = 0;
                foreach (var oElemento in Objetos)
                {
                    if (oElemento.GetType().Name == "CajaCOMPOSITE")
                        Valor += ((CajaCOMPOSITE)oElemento).ValorTotal;
                    else
                        Valor += oElemento.Cantidad;
                }

                return Valor;

            }
        }
        //Creacion del metodo para ingresar objeto a la caja
        public void Add(COMPONENT oElemento)
        {
            Objetos.Add(oElemento);
        }
        //Creacion del metodo para quitar objeto de la caja
        public void Remove(COMPONENT oElemento)
        {
            Objetos.Remove(oElemento);
        }
        //Constructor de la clase
        public CajaCOMPOSITE(string Nombre, int Cantidad = 0) : base(Nombre, Cantidad)
        {
        }
    }
}