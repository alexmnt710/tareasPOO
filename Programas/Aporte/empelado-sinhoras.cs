class empleado_sinhoras:empleado{
    public empleado_sinhoras(string nombre, int horasT, int sueldoH):base(nombre, horasT, sueldoH){

    }
    public override double CalcularSalario()
    {
        double total;

        total= horasT*sueldoH;

        return total;
    }
}