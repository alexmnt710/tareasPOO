internal class Program
{
    private static void Main(string[] args)
    {
        empleado_sinhoras empleado = new empleado_sinhoras("Juan",40,2);
        empleado_horasDobles empleado_desesperado = new empleado_horasDobles("Alex",43,2);
        empleado_horasTriples empleado_recien_egresado = new empleado_horasTriples("Johan",46,2);

        List<empleado> empleados = new List<empleado>();
        empleados.Add(empleado);
        empleados.Add(empleado_desesperado);
        empleados.Add(empleado_recien_egresado);

        foreach(empleado item in empleados)
        {
            Console.WriteLine(item.ToString()+" horas trabajadas: "+item.horasT+", sueldo por hora: "+item.sueldoH+" y su salario es: "+item.CalcularSalario());
        }
    }
}