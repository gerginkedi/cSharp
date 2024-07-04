namespace metod
{
    internal class Program
    {

            #region geriye deger gondermeyen, parametre almayan metod

            public void Metod1()
            {
            Console.WriteLine("geriye deger gondermeyen metod");
        }

            #endregion

            #region geriye deger gonderymeyen, parametre alan metod

            public void Metod2(bool x, decimal y) 
            {
            Console.WriteLine(x + " " + y  );
        }

            #endregion

            #region geriye deger gonderen parametre almayan metod

            private int metod3()
            {
            Console.WriteLine("sdfjkds");

            return 4; //geri gonderilen deger
            }

            #endregion

            #region geriye deger gonderen, parametre alan metod

            public string metod4(string x, string y)
            {
            Console.WriteLine("geriye deger gonderen, parametre alan metod");
            return x + " " + y; //gonderilen deger
            }
                
            #endregion

            

            #region kullanimi
            #endregion



            
        static void Main(string[] args)
        {

            #region tanim
            //metodlar islem parcacigidir
            #endregion

            #region kural

            //erisim belirleyicisi
            //public private
            //public disardan erisilebilir demek tum siniflardan
            //private sadece tanimlandigi siniftan erisilir
            //eger bi metod geriye deger dondermiyosa void keywordu kullanilir

            #endregion

            #region Tanimlama
            #endregion



        }
    }
}