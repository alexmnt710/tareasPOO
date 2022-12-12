using System;

namespace ConsoleApp6
{
    internal class Program
      {
        static void Main(string[] args)

        {
            //Creamos los objetos que se introduciran en lña caja
            OBJETOS Objeto1 = new OBJETOS("Zapatos",2,"Negros","9/12/2022");
            OBJETOS Objeto2 = new OBJETOS("Collar",1,"Plateado","9/12/2022");
            OBJETOS Objeto3 = new OBJETOS("Camisas",4,"Rojas","9/12/2022");
            OBJETOS Objeto4 = new OBJETOS("Gorra",1,"Blanca","9/12/2022");

            //Introducimos los objetos a la caja

            CajaCOMPOSITE Caja = new CajaCOMPOSITE("Cajon");
            Caja.Add(Objeto1);
            Caja.Add(Objeto2);
            Caja.Add(Objeto3);
            Caja.Add(Objeto4);

            //Consultamos el numero de objetos guardados

            Console.WriteLine("La cantidad de objetos en la caja es :");

            Console.WriteLine(Caja.ValorTotal);

        }
    }
}