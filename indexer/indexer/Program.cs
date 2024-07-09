namespace indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human[1] = "omer";
            human[2] = "ahmet";
            Console.WriteLine(human[1]);
            Console.WriteLine(human[2]);

        }
    }
    class Human
    {
        string[] names = new string[10];
        public string this[int i]
        {
            
            get 
            {
                return names[i];
            }
            set 
            {
                names[i] = value;      
            }

            
        }
    }
}