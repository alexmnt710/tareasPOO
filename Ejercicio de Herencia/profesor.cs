class profesor:persona{
    private int numeroDespacho{get; set;}
    private int anioIncorporacion{get; set;}
    private string departamento{get;set;}
    public profesor(string nombre, string apellido, int numeroIdentificacion, string estadoCivil, int numeroDespacho,int anioIncorporacion,string departamento):base(nombre, apellido, numeroIdentificacion, estadoCivil){
        this.numeroDespacho=numeroDespacho;
        this.anioIncorporacion=anioIncorporacion;
        this.departamento=departamento;
    }

    public void cambioDepartamento(string departamento2){
        departamento=departamento2;
    }
    public void cambioDespacho(int numeroDespacho2){
        numeroDespacho=numeroDespacho2;
    }
}