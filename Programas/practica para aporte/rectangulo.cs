class rectangulo:figura{
    private double Base{get;set;}
    private double Altura{get;set;}

    public rectangulo(string nombre, string color,double Base, double Altura):base(nombre, color){
        this.Base=Base;
        this.Altura=Altura;
    }
    public override double CalculoArea(){
        double area;
        area= Base*Altura;

        return area;
    }

}