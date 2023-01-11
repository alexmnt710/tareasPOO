class empleado_horasTriples:empleado{
    private int horasEx;
    public empleado_horasTriples(string nombre, int horasT, int sueldoH):base(nombre, horasT, sueldoH){
        
    }

    public override double CalcularSalario()
    {
        double total;
        
        horasEx= ((horasT-40)*3)*horasT;

        total= (horasT*sueldoH)+horasEx;

        return total;
    }
}