internal partial class Program
{
    private static void Main(string[] args)
    {
        int lado1, lado2, lado3;
        string respuesta;
        do{
            Console.WriteLine("Ingrese tres numeros por favor");

            Console.WriteLine("Ingrese el primero por favor");
            lado1= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo por favor");
            lado2= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercero por favor");
            lado3= int.Parse(Console.ReadLine());

            if((lado1 == lado2 && lado1!=lado3)||(lado2==lado3&&lado2!=lado1)||(lado3==lado1&&lado3!=lado2)){
                Console.WriteLine("Los lados forman un triangulo isosceles");
            }
            if(lado1==lado2 && lado1==lado3){
                Console.WriteLine("Los lados forman un triangulo equilatero");
            }
            if(lado1 != lado2 && lado1!= lado3 && lado2!= lado3){
                Console.WriteLine("Los lados forman un triangulo escaleno");
            }

            Console.WriteLine("Quieres volver a hacerlo?(S para si y N para no)");
            respuesta = Console.ReadLine().ToUpper();

        }while(respuesta!="N");
    }
}