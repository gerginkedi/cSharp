namespace isiim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "mert", "ali", "omer", "hortum"};
            string[] soyisim = { "kapioren", "cok", "postal", "ucu" };
            string[] mail = { "mert@gmail.com", "ali@gmail.com", "omer@gmail.com", "hortum@gmail.com"};
            int[] yas = { 23, 73, 34, 21 };
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i] + " " + soyisim[i] + " " + yas[i] + " " + "yasinda"+ " " + mail[i]);
            }
        }
    }
}