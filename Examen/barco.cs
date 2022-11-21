class barco{
    private string nombre{get;set;}
    private int capacidadP{get;set;}
    private int capacidadC{get;set;}

    public barco(string nombre, int capacidadP, int capacidadC){
        this.nombre=nombre;
        this.capacidadP=capacidadP;
        this.capacidadC=capacidadC;
    }

    public void ImprimirBarco(){
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Capacidad de pasajeros: "+capacidadP);
        Console.WriteLine("Capacidad de carga: "+capacidadC+"kg");
    }
}