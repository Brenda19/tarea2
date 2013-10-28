

namespace t2
{
	
	public class Segunda : Primera
	{
		
 
  protected int sueldo;

        public int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

      new public void Imprime()
        {
            base.Imprime();
            Console.WriteLine("Sueldo: " + sueldo);
        
        }
    }
}