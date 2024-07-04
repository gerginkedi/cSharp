namespace aynne
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Console.WriteLine(NumbersOnly(input));
        }
        static int NumbersOnly(string input2)
        {
            string onlyNumbers = new string(input2.Where(char.IsDigit).ToArray());
            int sa = int.Parse(onlyNumbers);
            return sa;
        }

        
        
    }
}