class persona{
    private string nombre{get;set;}
    private string apellido{get;set;}
    private int numeroIdentificacion{get;set;}
    private string estadoCivil{get;set;}

    public persona(string nombre, string apellido, int numeroIdentificacion, string estadoCivil){
        this.nombre=nombre;
        this.apellido=apellido;
        this.numeroIdentificacion=numeroIdentificacion;
        this.estadoCivil=estadoCivil;
    }

    public void cambiarEstadoCivil(string estadoCivil2){
        estadoCivil=estadoCivil2;
    }
    public void Imprimir(){
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Apellido: "+apellido);
        Console.WriteLine("ID: "+numeroIdentificacion);
        Console.WriteLine("Estado Civil: "+estadoCivil);
    }
}