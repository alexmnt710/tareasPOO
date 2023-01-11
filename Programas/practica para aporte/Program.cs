internal class Program
{
    private static void Main(string[] args)
    {
        circulo circulo= new circulo("rawr","rojo",3.14,9);
        cuadrado cuadrado=new cuadrado("pepe","azul",5);
        rectangulo rectangulo=new rectangulo("maria","verde",5,3);

        List<figura> figuras = new List<figura>();
        figuras.Add(circulo);
        figuras.Add(cuadrado);
        figuras.Add(rectangulo);

        foreach(figura item in figuras)
        {
            Console.WriteLine("El area del "+item.ToString()+" es "+item.CalculoArea());
        }
        



    }
}