
using System;

namespace t2
{
	
	public class Primera{
	
		
		protected string nombre;
        protected int edad;
       

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void Imprime()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            
            
        }
    }
}