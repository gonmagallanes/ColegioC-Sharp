using System;
using System.Security;

public class Datos {

    Menu oMenu;
    public Datos(){
        this.oMenu = new Menu();
    }

    public string nombreAlumno1 {get; set;}
    public string nombreAlumno2 {get; set;}
    public string nombreAlumno3 {get; set;}
    public int notaAlumno1 {get;set;}
    public int notaAlumno2 {get;set;}
    public int notaAlumno3 {get;set;}
    public int cantAprobados(){
        int cantAprobados = 0;

        if (this.notaAlumno1 >= 4){
            cantAprobados++;
        }
        if (this.notaAlumno2 >= 4){
            cantAprobados++;
        }
        if(this.notaAlumno3 >= 4){
            cantAprobados++;
        }
        return cantAprobados;
    }    

    public int notaPromedio(){
        int notaPromedio = this.notaAlumno1 + this.notaAlumno2 + this.notaAlumno3;

        return notaPromedio;

    }
    
    
}