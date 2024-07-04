namespace try_cath
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("lutfen sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi + " girdiniz.");
            }
			catch (Exception ex) 
			{
                Console.WriteLine("lutfen sadece sayi giriniz");
            }
        }
    }
}