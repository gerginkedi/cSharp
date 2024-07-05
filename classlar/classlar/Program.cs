namespace classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Ornek abc = new Ornek();
            //nesneler herzaman heapde olusturulur
            //stackdeki bir referans noktasindan heapdeki nesneye gider
            new Ornek(); //bunu bir referansi yoktur. dogurdan erisilemez
            //garbage collector referansi olmayan nesneleri siler
            Ornek x;
            x = new Ornek();
            //once referans uretilir sonra objesi uretilir
            Ornek y = new Ornek();
            Ornek k = y;
            //y a objesini gosteriyosa k da ayni objeyio gosteriyo
            int j = 0;
            int m = j;
            //burda deger kopyalanarak yazilir 
            if (y.Equals(k))
            {
                Console.WriteLine("esit");
            }
            else
            {
                Console.WriteLine( "degil");
            }
        }
    }
}