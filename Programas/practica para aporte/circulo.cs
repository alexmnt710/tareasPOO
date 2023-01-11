class circulo:figura{
    private double Pi{get;set;}
    private double radioC{get;set;}

    public circulo(string nombre, string color,double Pi, double radioC):base(nombre, color){
        this.Pi=Pi;
        this.radioC=radioC;
    }
    public override double CalculoArea(){
        double area;
        area= Pi*radioC;
        
        return area;
    }

}