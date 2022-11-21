class gps{
    private string coordenadasX{get;set;}
    private string coordenadasY{get;set;}
    private string fecha{get;set;}
    private int diasTripulados{get;set;}

    public gps(string coordenadasX,  string coordenadasY, string fecha, int diasTripulados){
        this.coordenadasX=coordenadasX;
        this.coordenadasY=coordenadasY;
        this.fecha=fecha;
        this.diasTripulados=diasTripulados;
    }
}