class empleado_horasDobles:empleado{
    private int horasEx;
    public empleado_horasDobles(string nombre, int horasT, int sueldoH):base(nombre, horasT, sueldoH){
        
    }
    
    public override double CalcularSalario()
    {
        double total;

        horasEx= (horasT-40)*2;

        total= (horasT*sueldoH)+horasEx;

        return total;
    }
}