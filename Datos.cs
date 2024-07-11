using System;
using System.Security;

public class Datos {
    
    public int eleccion{get;set;}

    public string nombreAlumno1 {get; set;}
    public string nombreAlumno2 {get; set;}
    public string nombreAlumno3 {get; set;}
    public int notaAlumno1 {get;set;}
    public int notaAlumno2 {get;set;}
    public int notaAlumno3 {get;set;}

    public int cantAprobados(){
        int intAprobados = 0;

        if (this.notaAlumno1 >= 4){
           intAprobados = intAprobados + 1;
        }
        if (this.notaAlumno2 >= 4){
            intAprobados = intAprobados + 1;
        }
        if(this.notaAlumno3 >= 4){
            intAprobados = intAprobados + 1;
        }
        return intAprobados;
    }    

    public double notaPromedio(){

        double notaPromedio = (this.notaAlumno1 + this.notaAlumno2 + this.notaAlumno3) / 3;

        return notaPromedio;

    }
    
}