internal partial class Program
{
    private static void Main(string[] args)
    {
        int contador=0, numero1, total=0;
        do{
            contador++;
            Console.WriteLine("Ingrese un numero por favor (Si ingresa un 0, programa terminara)");
            numero1= int.Parse(Console.ReadLine());
            total=total+numero1;

        }while(numero1!=0);
        total=total/contador;
        Console.WriteLine("La media aritmetica de los numeros ingresados fueron: "+total);
    }
}