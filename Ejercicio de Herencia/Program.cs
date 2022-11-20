internal class Program
{
    private static void Main(string[] args)
    {
        estudiante estudiante1=new estudiante("Alex","Meneses",1316819885,"soltero","3C");
        profesor profesor1=new profesor("Lucas","Macias",1316819885,"tristemente casado",506,1968,"Matematicas");
        trabajadorS trabajadorS1=new trabajadorS("Roberto","Gulag",65956,"divorcidado",710,1970,"biblioteca");

        estudiante1.cambiarEstadoCivil("Union libre");
        estudiante1.matricula("4C");
        estudiante1.Imprimir();

       profesor1.cambiarEstadoCivil("Divorciado");
       profesor1.cambioDepartamento("Algebra");
       profesor1.cambioDespacho(50);
       profesor1.Imprimir();

       profesor1.cambiarEstadoCivil("Casado");
       profesor1.cambioDepartamento("Decanato");
       profesor1.cambioDespacho(630);
       profesor1.Imprimir();
    }
}