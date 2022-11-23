internal class Program
{
    private static void Main(string[] args)
    {
        barco barco1=new barco("Tercero A",20000,6000);
        barco1.ImprimirBarco();
        gps gps1=new gps("8´24´54","9´23´21","18/11/2022",30);

        marinero marinero1=new marinero("Alex","09876589","131658965",28,10,"M","El perla negra",1000);
        marinero marinero2=new marinero("Maria","09876536","131658985",28,10,"F","El perla negra",2000);
        marinero marinero3=new marinero("Jose","09876552","131658932",28,10,"M","El perla negra",1500);
        marinero marinero4=new marinero("Diego","09876570","131658980",28,10,"M","El perla negra",1000);

        jefeFlota jefeFlota1=new jefeFlota("Marlo","09876525","131658993",38,10,"M","El perla negra",50,100);
        jefeFlota jefeFlota2=new jefeFlota("Ely","098765710","1316589107",30,10,"F","El perla negra",500,150);

        capitan capitan1=new capitan("Alexander","1316819885","0983733654",19,2,"M","El Perla Negra",4380);
        

        List<tripulante> tripulantes = new List<tripulante>();
        tripulantes.Add(marinero1);
        tripulantes.Add(marinero2);
        tripulantes.Add(marinero3);
        tripulantes.Add(marinero4);

        tripulantes.Add(jefeFlota1);
        tripulantes.Add(jefeFlota1);

        tripulantes.Add(capitan1);

        foreach(tripulante item in tripulantes)
        {
            Console.WriteLine("El tripulante con los datos: ");
            item.Imprimir();

            Console.WriteLine("Tiene un sueldo total de: "+item.Sueldo());
            
        }
        


    }
}
