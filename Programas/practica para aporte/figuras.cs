abstract class figura{
    private string nombre{get;set;}
    private string color{get;set;}

    public abstract double CalculoArea();

    public figura(string nombre, string color){
        this.nombre=nombre;
        this.color=color;
    }
    public void Imprimir(){
        Console.WriteLine("El nombre es "+nombre+ " y el color es "+color);
    }

}