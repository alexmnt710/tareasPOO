internal partial class Program
{
    private static void Main(string[] args)
    {
        int numero, factorial=1;
        Console.WriteLine("Ingrese un numero por favor");
        numero= int.Parse(Console.ReadLine());

        for(int i=1; i<=numero;i++){
            factorial=factorial*i;
        }

        Console.WriteLine("El factorial de "+numero+" es "+factorial);

    }
}