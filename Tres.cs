
using System;

namespace t2
{
	
	public class Tres{
	
      static void Main(string[] args)
        {
            Primera person = new Primera();
            person.Nombre = "Pablo";
            person.Edad =28;
            Console.WriteLine("Informacion del jefe ");
            person.Imprime();

            Segunda emple = new Segunda();
            emple.Nombre = "Daniela";
            emple.Edad = 21;
            emple.Sueldo = 2524;
            Console.WriteLine("Informacion del empleado ");
            emple.Imprime();

            Console.ReadKey();
        }
    }
}
   
 
       
      
     
 
      
  
 

		

