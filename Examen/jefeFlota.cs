class jefeFlota:tripulante{
    private int pesoPescado{get;set;}
    private int pesoMarisco{get;set;}
    private int sueldo=3500;

    private double bonoPescado, bonoMarisco,totalSueldo;

    public jefeFlota(string nombre,string telefono,string cedula, int edad, int tiempoenEmpresa, string sexo, string barco, int pesoPescado,int pesoMarisco):base(nombre,telefono,cedula,edad,tiempoenEmpresa,sexo,barco){
        this.pesoPescado=pesoMarisco;
        this.pesoMarisco=pesoMarisco;
    }
    public double CalculoBonoPescado(){
        bonoPescado=pesoPescado*0.01;
        return bonoPescado;
    }
    public double CalculoBonoMarisco(){
        bonoMarisco=pesoMarisco*0.02;
        return bonoMarisco;
    }
    public override double Sueldo()
    {
        totalSueldo=sueldo+bonoPescado+bonoMarisco;
        return totalSueldo;
    }
    public override void Imprimir()
    {
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Telefono: "+telefono);
        Console.WriteLine("Cedula: "+cedula);
        Console.WriteLine("Edad: "+edad);
        Console.WriteLine("Tiempo en la empresa: "+tiempoenEmpresa);
        Console.WriteLine("Sexo: "+sexo);
        Console.WriteLine("Barco: "+barco);
        Console.WriteLine("Peso Pescado: "+pesoPescado);
        Console.WriteLine("Peso Marisco: "+pesoMarisco);
        Console.WriteLine("Sueldo: "+sueldo);


    }


}