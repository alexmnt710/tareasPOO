abstract class empleado{
    private string nombre{get;set;}
    public int horasT{get;set;}
    public int sueldoH{get;set;}
    public abstract double CalcularSalario();
    public empleado(string nombre, int horasT, int sueldoH){
        this.nombre=nombre;
        this.horasT=horasT;
        this.sueldoH=sueldoH;
    }
    public void Imprimir(){
        Console.WriteLine("El nombre del trabajador es: "+nombre+", sus horas de trabajo son: "+horasT+" y su sueldo por hora es: "+sueldoH);
    }
}