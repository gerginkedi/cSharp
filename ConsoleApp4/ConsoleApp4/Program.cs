using System.Xml;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region break
            //break komutu sadece switch ve dongulerde kullanilir

            //for (int i = 0; i <=10; i++)
            //{
            //        for(int j = 0; j <=10; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            #endregion


            #region continue
            //continue komutunu gordukten sonra compiler o komuttan sonrasini gormuyo
            int k = 0;
            while (k<10)
            {
                Console.WriteLine(k);
                continue;
                k++;
                //sonsuz dongu

            }


            #endregion



        }
    }
}