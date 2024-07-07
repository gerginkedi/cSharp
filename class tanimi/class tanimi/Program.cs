namespace class_tanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Okul o = new Okul();
            Okul.Ogretmen ogretmen = new Okul.Ogretmen();
            Ornek or = new Ornek();
            or.Adi = "merhaba ";
            or.Sayi = 1453;
            Console.WriteLine(or.Adi1);
        }
    }

    
    class Okul
    {
        public class Ogretmen
        {

        }
    }

    class Ornek
    {
        #region field

        int x;          // sinif icerisinde tanimlanan degiskenlere field denir
                        // varsayilan degerler atanir
        string y;       // stringin varsayilan degeri null, intin 0, boolun false   

        #endregion

        #region Property
        //sinif icersindeki yapilari disariya kontrollu bir sekilde acmamizi saglayan yapilardir
        string adi;

        public string Adi
        {
            get// field uzerinden calisirken her zaman get ve set kullan
            {
                return adi.Substring(0, 2);
            }
            set 
            {
                adi = value.ToUpper();
            }
        }

        


        #endregion

        #region property

        bool o;
        public bool O
        {
            get
            {
                return o;
            }
            set
            {
                o = value;
            }
        }

        #endregion

        #region property 2

        public int Sayi { get; set; }

        #endregion

        #region auto property initalizers

        public string Adi1 { get; set; } = "omer";


        #endregion



    }
}