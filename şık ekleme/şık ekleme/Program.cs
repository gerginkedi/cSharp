namespace şık_ekleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prg1 = "0";
            string prg2 = "0";
            string prg3 = "0";
            string prg4 = "0";
            string prg5 = "0";
            string number = Console.ReadLine();
            int no = Int16.Parse(number);
            for (int i = 1; i <= no; i++)
            {

                Console.WriteLine("lütfen paragrfı giriniz");
                string prg = Console.ReadLine();
                switch (i)
                {
                    case 1:
                        prg1 = prg;
                        break;

                    case 2:
                        prg2 = "A:" + prg;
                        break;

                    case 3:
                        prg3 = "B:" + prg;
                        break;

                    case 4:
                        prg4 = "C:" + prg;
                        break;

                    case 5:
                        prg5 = "D:" + prg;
                        break;
                }
                Console.Clear();
                Console.WriteLine(prg1);
                Console.WriteLine(prg2);
                Console.WriteLine(prg3);
                Console.WriteLine(prg4);
                Console.WriteLine(prg5);

            }
            
        }
    }
}