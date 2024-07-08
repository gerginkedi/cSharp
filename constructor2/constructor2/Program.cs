using System.Runtime.CompilerServices;

namespace constructor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek k = new Ornek();
            Console.WriteLine(k.x);
            
        }

        class Ornek
        {
            public int x { get; set; }
            

            public Ornek() 
            {
                x = 12;
               
            }
        }
    }
}