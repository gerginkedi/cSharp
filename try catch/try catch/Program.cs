namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Derlem Hatasi

            //compilerda verdigi hatadir
            // int a = "123" gibi

            #endregion

            #region Mantiksal Hata

            //int[] k = { 1, 2, 3 };
            //Console.WriteLine(k[3]); burda k dizisinin 3. bir elemani olmadigi icin calistigi zaman error vercektir

            #endregion

            #region run time error

            //Console.WriteLine("lutfen sayi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi + " " + "girdiniz"); burda girdi olarka sayi girmessek run time error verir
            
            #endregion
        }
    }
}