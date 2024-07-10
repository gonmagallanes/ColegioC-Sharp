namespace PrimerParcialMagallanes;

class Program
{
    static void Main(string[] args)
    {
        Menu oMenu;
        oMenu = new Menu();

        Datos oDatos;
        oDatos = new Datos();

        do{

            Console.Clear();
            Console.WriteLine("Presione el numero con el cual quiera interactuar. ");
            Console.WriteLine("1- Introducir datos ");
            Console.WriteLine("2- Ver cantidad de aprobados");
            Console.WriteLine("3- Ver promedio general");
            Console.WriteLine("4- Salir");

            do{

            oMenu.eleccion = int.Parse(Console.ReadLine());

            }while (oMenu.eleccion != 1 && oMenu.eleccion != 2 && oMenu.eleccion != 3 && oMenu.eleccion != 4);
        
            switch(oMenu.eleccion){
                case 1: 
                    Console.WriteLine("Introducir nombre del primer alumno");
                    oDatos.nombreAlumno1 = Console.ReadLine();
                    Console.WriteLine("Introducir nota del primer alumno");
                    oDatos.notaAlumno1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Introducir nombre del segundo alumno");
                    oDatos.nombreAlumno2 = Console.ReadLine();
                    Console.WriteLine("Introducir nota del segundo alumno");
                    oDatos.notaAlumno2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Introducir nombre del tercer alumno");
                    oDatos.nombreAlumno3 = Console.ReadLine();
                    Console.WriteLine("Introducir nota del tercer alumno");
                    oDatos.notaAlumno3 = int.Parse(Console.ReadLine());
                    break;
                case 2: 
                    Console.WriteLine($"Cantidad de aprobados: {oDatos.cantAprobados}");
                    break;
                case 3: 
                    break;
                case 4: 
                    break;
            
            }
        }while(oMenu.eleccion == 4);
        
    }
}
