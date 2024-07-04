namespace konsolapp
{
    internal class Program
    {

        
        static void Main(string[] args)
        {

            #region degiskenler
            //string ad;
            //char basHarf;
            //int sayi;
            //bool evetHayir;
            #endregion


            #region kullanim 1
            string ad;
            ad = "omer";
            #endregion

            #region kullanim 2
            string soyad = "altuntas";
            #endregion

            #region kullanim 3
            string a, b, c;
            a = "a";
            b = "b";
            c = "c";
            #endregion

            #region degiskeni degiskene atama
            int x = 2;
            int y = x;
            y = y - 2;
            int z = x - y;
            #endregion

            #region var ve object
            var q = "q";
            var s = 123; //var dinamic bir degiskendir karsisina ne yazarsan onun turune donusur

            object k = "sabfasdf";
            object l = 123; //objectise icine ekledigin sey ne olursa olsun onu objecte cevirir yani boxing yapar 
            #endregion

            #region boxing
            object kuk = 12;
            #endregion
            #region unboxing
            string hoh = (string)kuk;
            #endregion


            #region tip cevrimleri
            string ucak = "123";
            int kapi = Convert.ToInt32(ucak);

            Console.WriteLine(ucak);
            Console.ReadLine();
            #endregion


        }
    }
}