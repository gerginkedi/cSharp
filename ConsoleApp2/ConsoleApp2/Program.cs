namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                for (int index = 0; index < args.Length; index++)
                {
                    Console.WriteLine(@"Parameter " + index.ToString() + " : " + args[index].ToString());
                }
                
            }
            
        }
    }
}