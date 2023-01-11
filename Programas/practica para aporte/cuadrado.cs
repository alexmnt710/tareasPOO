class cuadrado:figura{
    private double  lado{get;set;}

    public cuadrado(string nombre, string color,double lado):base(nombre, color){
        this.lado=lado;
    }
    public override double CalculoArea(){
        double area;
        area= lado*lado;

        return area;
    }

}