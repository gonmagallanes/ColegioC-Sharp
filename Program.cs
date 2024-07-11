namespace PrimerParcialMagallanes;

class Program
{
    static void Main(string[] args)
    {

        Datos oDatos;
        oDatos = new Datos();

        do{

            Console.WriteLine("Presione el numero con el cual quiera interactuar. ");
            Console.WriteLine("1- Introducir datos ");
            Console.WriteLine("2- Ver cantidad de aprobados");
            Console.WriteLine("3- Ver promedio general");
            Console.WriteLine("4- Salir");
            
            oDatos.eleccion = Console.ReadLine();
        
            switch(oDatos.eleccion){
                case "1": 

                    Console.WriteLine("Introducir nombre del primer alumno");
                    oDatos.nombreAlumno1 = Console.ReadLine();

                    try {
                        
                        Console.WriteLine("Introducir nota del primer alumno");
                        oDatos.notaAlumno1 = int.Parse(Console.ReadLine());                

                        if (oDatos.notaAlumno1 < 0 || oDatos.notaAlumno1 > 10) {
                            do {
                                Console.WriteLine("Por favor introducir una nota del 0 al 10");
                                oDatos.notaAlumno1 = int.Parse(Console.ReadLine());         
                            }while(oDatos.notaAlumno1 < 0 || oDatos.notaAlumno1 > 10);
                        }   
                    }catch{
                        Console.WriteLine("Definir nota con numeros, nota definida temporalmente como 1(uno)");
                        oDatos.notaAlumno1 = 1;
                    }
                                           
                              
                    Console.WriteLine("Introducir nombre del segundo alumno");
                    oDatos.nombreAlumno2 = Console.ReadLine();

                    try {
                        Console.WriteLine("Introducir nota del segundo alumno");
                        oDatos.notaAlumno2 = int.Parse(Console.ReadLine());

                        if (oDatos.notaAlumno2 < 0 || oDatos.notaAlumno2 > 10) {
                            do {
                                Console.WriteLine("Por favor introducir una nota del 0 al 10");
                                oDatos.notaAlumno2 = int.Parse(Console.ReadLine());         
                            }while(oDatos.notaAlumno2 < 0 || oDatos.notaAlumno2 > 10);
                        }
                    }catch{
                        Console.WriteLine("Definir nota con numeros, nota definida temporalmente como 1(uno)");
                        oDatos.notaAlumno2 = 1;
                    }
                    

                    Console.WriteLine("Introducir nombre del tercer alumno");
                    oDatos.nombreAlumno3 = Console.ReadLine();

                    try{

                        Console.WriteLine("Introducir nota del tercer alumno");
                        oDatos.notaAlumno3 = int.Parse(Console.ReadLine());

                        if (oDatos.notaAlumno3 < 0 || oDatos.notaAlumno3 > 10) {
                            do {
                                Console.WriteLine("Por favor introducir una nota del 0 al 10");
                                oDatos.notaAlumno3 = int.Parse(Console.ReadLine());         
                            }while(oDatos.notaAlumno3 < 0 || oDatos.notaAlumno3 > 10);
                        }

                    }catch{

                        Console.WriteLine("Definir nota con numeros, nota definida temporalmente como 1(uno)");
                        oDatos.notaAlumno3 = 1;
                        
                    }
                    

                    break;
                case "2": 
                    Console.WriteLine("Cantidad de aprobados: " + oDatos.cantAprobados());
                    break;
                case "3": 
                    Console.WriteLine("La nota promedio es de: " + oDatos.notaPromedio());
                    break;
                case "4": 
                    Console.Beep(659, 125); 
                    Console.Beep(659, 125); 
                    Thread.Sleep(125); 
                    Console.Beep(659, 125); 
                    Thread.Sleep(167); 
                    Console.Beep(523, 125); 
                    Console.Beep(659, 125); 
                    Thread.Sleep(125); 
                    Console.Beep(784, 125);
                    Thread.Sleep(375); 
                    Console.Beep(392, 125);
                    break;
            
            }
        }while(oDatos.eleccion != "4");
        
    }
}
