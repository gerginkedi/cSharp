namespace destrcutor_ve_garbage_cleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) 
            {
                new Ornek(i);
                
            }
            Console.WriteLine("**************");
            
            GC.Collect();
            Console.Read();// olmayinca calismiyo
        }


        class Ornek 
        {

            int numara;
            public Ornek(int id)
            {// constructor
                numara = id;
                Console.WriteLine(numara + " idli nesne uretildi");
            }



        }
    }
}