namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int tekIndex = 0;
            int ciftIndex = 0;
            int sayi1Index = 0;
            int sayi2Index = 0;
            int[] sayilar = { 24, 1, 2, 3, 324, 123, 234, 567, 234, 547, 23, 3456, 56, 2133 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2 == 0)
                {
                    ciftIndex++;
                }
                else
                {
                    tekIndex++;
                }
            }









            int[] ciftSayiCarpimiSonucu = new int[ciftIndex]; //baslangicta cift olanlari attiklarimiz
            int[] tekSayiCarpimiSonucu = new int[tekIndex]; //baslangicta tek olanlari attiklarimiz
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {

                    if (i == 0)
                    {
                        ciftSayiCarpimiSonucu[sayi1Index] = sayilar[i] * sayilar[i];
                    }

                    else
                    {
                        ciftSayiCarpimiSonucu[sayi1Index] = sayilar[i] * sayilar[i - 1];
                    }
                    sayi1Index++;

                }

                else
                {
                    if (i == sayilar.Length - 1)
                    {
                        tekSayiCarpimiSonucu[sayi2Index] = sayilar[i] * sayilar[i] * sayilar[i];
                    }

                    else
                    {
                        tekSayiCarpimiSonucu[sayi2Index] = sayilar[i] * sayilar[i + 1];
                    }

                    sayi2Index++;
                }
            }

            Console.WriteLine("ilk dizi");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("===================");
            Console.WriteLine("a dizisi");
            for (int i = 0; i < ciftSayiCarpimiSonucu.Length; i++)
            {
                Console.WriteLine(ciftSayiCarpimiSonucu[i]); ;
            }
            Console.WriteLine("===================");
            Console.WriteLine("b dizisi");
            for (int i = 0; i < tekSayiCarpimiSonucu.Length; i++)
            {
                Console.WriteLine(tekSayiCarpimiSonucu[i]); ;
            }

        }
    }
}