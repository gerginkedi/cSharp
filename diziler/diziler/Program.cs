namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dizi tanimi
            //ayni tipte birden fazla veriyi tutabildigimiz ver kumesidir
            #endregion

            #region dizi tanimlama
            int[] yaslar = new int[25];
            string[] isimler = new string[25];

            #endregion

            #region deger atama
            yaslar[3] = 22;
            yaslar[4] = 23;
            yaslar[24] = 12;

            for (int i = 0; i <= 24; i++)
            {
                yaslar[i] = 14 + i;
            }

            ////////////////////////////////////////////// array.rank() ne ise yarar
            #endregion

            #region deger okuma

            //Console.WriteLine(yaslar[3]);
            //Console.WriteLine(yaslar[22]); // atanmayan deger istenirse 0 doner

            #endregion

            #region dongu ile dizi donme

            //for (int i = 0; i <= yaslar.Length; i++)
            //{
            //    Console.WriteLine(yaslar[i]);

            //}

            #endregion

            #region dizi tanimlama varyasyonlari

            //int[] x = new int[] { 12, 2, 3, 4, 4, 6, 54, 23, 32 }; // dizini eleman sayisi kac tane deger yazildiysa o kadardir
            //int[] x = { 12, 3, 41, 32, 12 }; // usttekinden farki yokmus
            //int[] x = new int[3] { 1, 2, 3, };
            #endregion



            #region array
            #region IsFixedSize
            //eleman sayisnin sabit olup olmadgini soyler boolean tipinde deger dondurur
            Console.WriteLine(yaslar.IsFixedSize);
            #endregion

            #region IsReadOnly
            //dizideki elemanlar sadece okunabilir olup olmadgini gosterir boolean tipinde deger dondurur
            Console.WriteLine(yaslar.IsReadOnly);
            #endregion

            #region length
            //dizdeki eleman sayisini soyler
            Console.WriteLine(yaslar.Length);

            #endregion


            #endregion

            #region metodlar

            #region clear
            for (int o = 0; o < yaslar.Length; o++)
            {
                Console.WriteLine(yaslar[o]);
            }

            Array.Clear(yaslar, 0, yaslar.Length);
            Console.WriteLine("=============================");
            for (int o = 0; o < yaslar.Length; o++)
            {
                Console.WriteLine(yaslar[o]);
            }
            #endregion

            #region copy

            Console.WriteLine("==================");
            int[] sayilar2 = new int[3];
            Array.Copy(sayilar2, sayilar2, 3);
            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(sayilar2[i]);
            }

            #endregion

            #region IndexOf
            //dizi icerisinde harf ya da kelime arar bulduug ilki indexi gonderir bulamazsa -1 gonderir
            Console.WriteLine(Array.IndexOf(yaslar, 0));
            #endregion

            #region reverse

            Console.WriteLine("==============================");
            Array.Reverse(yaslar);
            for (int i = 0; i < yaslar.Length; i++)
            {
                Console.WriteLine(yaslar[i]);
            }

            #endregion

            #endregion



        }
    }
}