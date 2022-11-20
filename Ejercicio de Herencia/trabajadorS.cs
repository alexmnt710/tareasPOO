class trabajadorS:persona{
    private int numeroDespacho{get; set;}
    private int anioIncorporacion{get; set;}
    private string seccion{get;set;}
    public trabajadorS(string nombre, string apellido, int numeroIdentificacion, string estadoCivil, int numeroDespacho,int anioIncorporacion,string seccion):base(nombre, apellido, numeroIdentificacion, estadoCivil){
        this.numeroDespacho=numeroDespacho;
        this.anioIncorporacion=anioIncorporacion;
        this.seccion=seccion;
    }

    public void cambioSeccion(string seccion2){
        seccion=seccion2;
    }
    public void cambioDespacho(int numeroDespacho2){
        numeroDespacho=numeroDespacho2;
    }
}